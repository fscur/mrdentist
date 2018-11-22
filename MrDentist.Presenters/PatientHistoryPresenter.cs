using MrDentist.Data;
using MrDentist.Models;
using MrDentist.Pages;
using System;
using System.Linq;

namespace MrDentist.Presenters
{
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

        public IPage Page => page;

        public event EventHandler<OdontogramEntry> OdontogramEntryPageRequested;

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
                RaiseOdontogramEntryPageRequested(appointment.OdontogramEntry);
            };
        }

        private void RaiseOdontogramEntryPageRequested(OdontogramEntry entry)
        {
            if (OdontogramEntryPageRequested != null)
                OdontogramEntryPageRequested.Invoke(this, entry);
        }
    }
}
