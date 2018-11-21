using MrDentist.Models;
using System;
using System.Collections.Generic;

namespace MrDentist.Pages
{
    public interface IPatientHistoryPage : IPage
    {
        event EventHandler<Appointment> SelectedAppointmentChanged;
        event EventHandler<Appointment> EditOdontogramEntryClicked;
        void SetSelectedOdontogramEntry(OdontogramEntry entry);
        void SetPatient(Patient patient);
        void SetPatientAppointments(List<Appointment> appointments);
        void ClearSelectedOdontogramEntry();
    }
}
