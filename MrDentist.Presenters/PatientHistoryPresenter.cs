using MrDentist.Data;
using MrDentist.Models;
using MrDentist.Net.Http;
using MrDentist.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MrDentist.Presenters
{
    public class OdontogramEntryPageRequestedEventArgs : EventArgs
    {
        public Odontogram Odontogram { get; set; }
        public OdontogramEntry Entry { get; set; }
    }

    public class PatientHistoryPresenter : IPatientHistoryPresenter
    {
        private readonly Dictionary<string, Image> odontogramImagesCache;

        private readonly IDataRepository dataRepository;
        private IPatientHistoryPage page;

        public Patient Patient { get; private set; }
        public IPage Page => page; 

        public event EventHandler<OdontogramEntryPageRequestedEventArgs> OdontogramEntryPageRequested;

        public PatientHistoryPresenter(IDataRepository dataRepository, IPatientHistoryPage page)
        {
            this.page = page;
            this.dataRepository = dataRepository;
            odontogramImagesCache = new Dictionary<string, Image>();

            page.SelectedAppointmentChanged += (s, appointment) =>
            {
                var date = appointment.Date;
                var entry = this.Patient.Odontogram.Entries.FirstOrDefault(t => t.Date == date);

                var entries = this.Patient.Odontogram.Entries.Where(t => t.Date <= date);

                if (entry != null)
                    page.SetOdontogramEntries(entries);
                else
                    page.ClearSelectedOdontogramEntry();
            };

            page.EditOdontogramEntryClicked += (s, appointment) =>
            {
                var e = new OdontogramEntryPageRequestedEventArgs()
                {
                    Odontogram = appointment.Patient.Odontogram,
                    Entry = appointment.OdontogramEntry
                };

                RaiseOdontogramEntryPageRequested(e);
            };

            page.NeedsReloading += (s, e) => {
                if (Patient != null)
                    SetPatient(dataRepository.Patients.Get(Patient.Id));
            };
        }

        private void RaiseOdontogramEntryPageRequested(OdontogramEntryPageRequestedEventArgs e)
        {
            if (OdontogramEntryPageRequested != null)
                OdontogramEntryPageRequested.Invoke(this, e);
        }

        public void SetParams(IPresenterParams @params)
        {
            var p = @params as PatientHistoryPresenterParams;

            SetPatient(p.Patient);
        }

        private void SetPatient(Patient patient)
        {
            if (patient == null)
                return;

            Patient = patient;

            var appointments = this.dataRepository.Appointments.GetByPatientAndDentist(patient, patient.Dentist).OrderBy(p => p.Date).ToList();

            page.SetPatient(patient);
            page.SetPatientAppointments(appointments);

            odontogramImagesCache.TryGetValue(patient.Odontogram.BaseImageUrl, out Image image);

            if (image == null)
            {
                var uri = new Uri(patient.Odontogram.BaseImageUrl);
                var downloader = new Downloader();
                var imageStream = downloader.DownloadAsync(uri).Result;
                image = Image.FromStream(imageStream);
                odontogramImagesCache.Add(patient.Odontogram.BaseImageUrl, image);
            }

            page.SetCanvasImage(image);

            if (appointments.Count > 0)
            {
                var entries = this.Patient.Odontogram.Entries.Where(t => t.Date <= appointments[0].Date);
                page.SetOdontogramEntries(entries);
            }
        }
    }
}