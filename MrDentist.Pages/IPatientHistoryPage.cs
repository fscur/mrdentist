using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MrDentist.Pages
{
    public interface IPatientHistoryPage : IPage
    {
        event EventHandler<Appointment> SelectedAppointmentChanged;
        event EventHandler<Appointment> EditOdontogramEntryClicked;
        void SetOdontogramEntries(IEnumerable<OdontogramEntry> entry);
        void SetPatient(Patient patient);
        void SetPatientAppointments(List<Appointment> appointments);
        void ClearSelectedOdontogramEntry();
        void SetCanvasImage(Image image);
    }
}
