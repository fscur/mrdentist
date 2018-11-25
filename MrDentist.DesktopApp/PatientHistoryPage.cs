using MrDentist.Data;
using MrDentist.DesktopApp.Extensions;
using MrDentist.Models;
using MrDentist.Models.Extensions;
using MrDentist.Net.Http;
using MrDentist.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MrDentist.DesktopApp
{
    public partial class PatientHistoryPage : Page, IPatientHistoryPage
    {
        public PatientHistoryPage()
        {
            TitleText = "Editar Prontuário";

            InitializeComponent();
            InitToolStrips();
            InitAppointmentsDataGridView();
        }

        public PatientHistoryPage(IDataRepository dataRepository, Patient patient, Dentist dentist)
        {
            TitleText = "Editar Prontuário";

            InitializeComponent();
            InitToolStrips();
            InitAppointmentsDataGridView();
        }

        public event EventHandler<Appointment> SelectedAppointmentChanged;
        public event EventHandler<Appointment> EditOdontogramEntryClicked;
        public event EventHandler NeedsReloading;

        private void InitAppointmentsDataGridView()
        {
            appointmentsDataGridView.SelectionChanged += (s, e) => {
                if (appointmentsDataGridView.SelectedRows.Count == 0)
                    return;

                var selectedRow = appointmentsDataGridView.SelectedRows[0];
                if (selectedRow.Tag == null)
                    return;

                RaiseSelectedAppointmentEntryChanged(selectedRow.Tag as Appointment);
            };
        }

        private void RaiseSelectedAppointmentEntryChanged(Appointment appointment)
        {
            if (SelectedAppointmentChanged != null)
                SelectedAppointmentChanged.Invoke(this, appointment);
        }

        private void RaiseEditOdontogramEntryClicked(Appointment appointment)
        {
            if (EditOdontogramEntryClicked != null)
                EditOdontogramEntryClicked.Invoke(this, appointment);
        }

        private void InitToolStrips()
        {
            this.ToolStrips = new List<ToolStrip>();
            var odontogramStrip = new ToolStrip();
            var editOdontogram = new ToolStripButton(Properties.Resources.odonto.ToBitmap());
            editOdontogram.ToolTipText = "Editar Odontograma";
            editOdontogram.Click += OpenOdontogramEntryPage;
            odontogramStrip.Items.Add(editOdontogram);
            ToolStrips.Add(odontogramStrip);
        }

        private void OpenOdontogramEntryPage(object s, EventArgs e)
        {
            var grid = appointmentsDataGridView;

            if (grid.SelectedRows.Count == 0)
                return;

            RaiseEditOdontogramEntryClicked(grid.SelectedRows[0].Tag as Appointment);
        }

        public void SetPatientAppointments(List<Appointment> appointments)
        {
            appointmentsDataGridView.Rows.Clear();

            foreach (var appointment in appointments)
            {
                var rowId = appointmentsDataGridView.Rows.Add();
                var newRow = appointmentsDataGridView.Rows[rowId];

                newRow.Cells["colId"].Value = appointment.Id;
                newRow.Cells["colDate"].Value = appointment.Date;
                newRow.Cells["colObservations"].Value = appointment.Observations;
                newRow.Cells["colExams"].Value = "...";
                newRow.Tag = appointment;
            }
        }

        public void SetOdontogramEntries(IEnumerable<OdontogramEntry> entries)
        {
            this.canvas.Shapes.Clear();

            foreach (var entry in entries)
            {
                entry.DentalIssues.ForEach(p => this.canvas.Shapes.Add(p.Shape));
            }
        }

        public void SetCanvasImage(Image image)
        {
            this.canvas.Image = image;
        }

        public void SetPatient(Patient patient)
        {
            nameLabel.Text = patient.Name;
            addressLabel.Text = patient.Address.Description;
            phoneLabel.Text = patient.Phones[0];
        }

        public void OpenPage(Page page)
        {
            RaiseNewPageRequested(page);
        }

        public void ClearSelectedOdontogramEntry()
        {
            this.canvas.Shapes.Clear();
        }

        public override void Reload()
        {
            var selectedRow = appointmentsDataGridView.SelectedRows.Count > 0 ? appointmentsDataGridView.SelectedRows[0].Index : 0;

            if (NeedsReloading != null)
                NeedsReloading.Invoke(this, new EventArgs());

            if (appointmentsDataGridView.Rows.Count > 0)
                appointmentsDataGridView.Rows[selectedRow].Selected = true;
        }
    }
}
