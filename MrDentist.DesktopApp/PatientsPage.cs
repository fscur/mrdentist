using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MrDentist.Data;
using MrDentist.Models;

namespace MrDentist.DesktopApp
{
    public partial class PatientsPage : Page
    {
        private IDataRepository dataRepository;
        private User loggedUser;

        public PatientsPage(User loggedUser, IDataRepository dataRepository)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            this.dataRepository = dataRepository;
            this.TitleText = "Pacientes";

            this.ContextMenuStrip = new ContextMenuStrip();
            InitCrudToolStrip();

            if (loggedUser.Type == UserType.Admin || loggedUser.Type == UserType.Dentist)
            {
                var menuItem = new ToolStripMenuItem("Editar Prontuário");
                menuItem.Image = Properties.Resources.dentistry.ToBitmap();
                menuItem.Click += (s, e) => OpenPatientHistoryPage();
                this.ContextMenuStrip.Items.Add(menuItem);
                InitPatientToolStrip();
            }
        }

        private void OpenPatientHistoryPage()
        {
            if (this.listviewPatients.SelectedItems.Count == 0)
                return;

            var patient = this.listviewPatients.SelectedItems[0].Tag as Patient;
            var dentist = this.dataRepository.Dentists.GetByUser(loggedUser);
            RaiseNewPageRequested(new PatientHistoryPage(dataRepository, patient, dentist));
        }

        private void InitPatientToolStrip()
        {
            var patientToolStrip = new ToolStrip();
            var editPatientHistoryButton = new ToolStripButton(Properties.Resources.dentistry.ToBitmap());
            editPatientHistoryButton.Click += (s, e) => OpenPatientHistoryPage();
            patientToolStrip.Items.Add(editPatientHistoryButton);
            this.ToolStrips.Add(patientToolStrip);
        }

        private void InitCrudToolStrip()
        {
            this.ToolStrips.Add(new CrudToolStrip(new PatientCrudToolStripActions()));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadUsersListView();
        }

        private void LoadUsersListView()
        {
            listviewPatients.Columns.Add("Name", 100);
            listviewPatients.Columns.Add("Address", 300);
            listviewPatients.Columns.Add("Phone", 150);

            var patients = this.dataRepository.Patients.All;

            foreach (var patient in patients)
            {
                listviewPatients.Items.Add(new ListViewItem(
                    new string[] {
                        patient.Name,
                        patient.Address != null ? patient.Address.Description : string.Empty,
                        patient.Phones.Count > 0 ? patient.Phones[0] : string.Empty})
                {
                    Tag = patient
                });
            }
        }
    }
}
