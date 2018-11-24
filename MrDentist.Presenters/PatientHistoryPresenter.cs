using MrDentist.Data;
using MrDentist.Models;
using MrDentist.Pages;
using System;
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
        private IDataRepository dataRepository;
        private IPatientHistoryPage page;
        private Patient patient;

        public Patient Patient
        {
            get { return patient; }
            set {
                if (patient == value)
                    return;
                
                patient = value;

                var appointments = this.dataRepository.Appointments.GetByPatientAndDentist(patient, patient.Dentist).ToList();

                page.SetPatient(patient);
                page.SetPatientAppointments(appointments);

                if (appointments.Count > 0)
                    page.SetSelectedOdontogramEntry(appointments[0].OdontogramEntry);
            }
        }

        public IPage Page => page;virtual 

        public event EventHandler<OdontogramEntryPageRequestedEventArgs> OdontogramEntryPageRequested;

        public PatientHistoryPresenter(IDataRepository dataRepository, IPatientHistoryPage page)
        {
            this.page = page;
            this.dataRepository = dataRepository;

            page.SelectedAppointmentChanged += (s, appointment) =>
            {
                var date = appointment.Date;
                var entry = this.Patient.Odontogram.Entries.FirstOrDefault(t => t.Date == date);

                if (entry != null)
                    page.SetSelectedOdontogramEntry(entry);
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
        }

        private void RaiseOdontogramEntryPageRequested(OdontogramEntryPageRequestedEventArgs e)
        {
            if (OdontogramEntryPageRequested != null)
                OdontogramEntryPageRequested.Invoke(this, e);
        }
    }
}
