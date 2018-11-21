using MrDentist.Data;
using MrDentist.Models;
using MrDentist.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MrDentist.DesktopApp
{
    static class Program
    {
        private static DataRepository dataRepository;

        private static void InitFakeData(User user)
        {
            var dentist0 = new Dentist()
            {
                Id = 0,
                Name = "Dentalino Almeida",
                Address = new Address() { Description = "Rua João Betega, 1340 - Apto. 501" },
                Phones = new List<string>() { "+5554996894581" },
                ProfessionalRegister = 1099,
                User = user
            };

            var dentist1 = new Dentist()
            {
                Id = 1,
                Name = "Floriano Marciano",
                Address = new Address() { Description = "Avenida Julio de Castilhos, 100" },
                Phones = new List<string>() { "+5554332222211" },
                ProfessionalRegister = 1111
            };

            var patient0 = new Patient()
            {
                Id = 0,
                Name = "Mario Zamelao",
                Address = new Address() { Description = "Rua João Betega, 1340 - Apto. 501" },
                Phones = new List<string>() { "+5554996894581" },
                BloodType = "AB+",
                InsuranceNumber = "188726663",
                Dentist = dentist0,
                Exams = new List<Exam>()
            };

            var date1 = new DateTime(2018, 7, 2);
            var odontogramEntry1 = new OdontogramEntry()
            {
                Id = 0,
                Date = date1,
                DentalEvents = new List<IDentalEvent>() {
                    new Cavity(0, new Models.PointF(100, 250))
                },
            };

            var odontogram1 = new Odontogram()
            {
                Entries = new List<OdontogramEntry>() {
                        odontogramEntry1
                    },
                BaseImage = System.Drawing.Image.FromFile("odontogramimages\\odontogram.jpg")
            };

            odontogramEntry1.Odontogram = odontogram1;

            var patient1 = new Patient()
            {
                Id = 1,
                Name = "Maria de Deus",
                Address = new Address() { Description = "Avenida Julio de Castilhos, 100" },
                Phones = new List<string>() { "+5554332222211" },
                BloodType = "O-",
                InsuranceNumber = "188726663",
                Dentist = dentist0,
                Exams = new List<Exam>(),
                Odontogram = odontogram1
            };

            dentist0.Patients.Add(patient0);
            dentist0.Patients.Add(patient1);

            dataRepository.Patients.Add(patient0);
            dataRepository.Patients.Add(patient1);
            dataRepository.Dentists.Add(dentist0);
            dataRepository.Dentists.Add(dentist1);

            dataRepository.Appointments.Add(new Appointment()
            {
                Id = 0,
                Attended = true,
                Date = new DateTime(2018, 7, 2),
                Dentist = dataRepository.Dentists.Get(0),
                Patient = dataRepository.Patients.Get(0),
                Observations = "O dente caiu da boca."
            });

            dataRepository.Appointments.Add(new Appointment()
            {
                Id = 1,
                Attended = true,
                Date = date1,
                Dentist = dataRepository.Dentists.Get(0),
                Patient = dataRepository.Patients.Get(1),
                Observations = "O dente estava podre.",
                OdontogramEntry = odontogramEntry1
            });

            dataRepository.Appointments.Add(new Appointment()
            {
                Id = 2,
                Attended = true,
                Date = new DateTime(2018, 9, 22),
                Dentist = dataRepository.Dentists.Get(0),
                Patient = dataRepository.Patients.Get(1),
                Observations = "O dente estava mais podre."
            });
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            dataRepository = new DataRepository();
            User loggedUser = new User("filipe.scur", string.Empty, UserType.Dentist);

            InitFakeData(loggedUser);

            var patientHistoryPage = new PatientHistoryPage();
            var patientHistoryPresenter = new PatientHistoryPresenter(dataRepository, patientHistoryPage);

            var odontogramEntryPage = new OdontogramEntryPage();
            var odontogramEntryPresenter = new OdontogramEntryPresenter(dataRepository, odontogramEntryPage);

            var pageBrowser = new PageBrowser(patientHistoryPage);

            patientHistoryPresenter.OdontogramEntryPageRequested += (s, e) =>
            {
                odontogramEntryPresenter.OdontograEntry = e;
                pageBrowser.OpenPage(odontogramEntryPage);
            };

            patientHistoryPresenter.Patient = dataRepository.Patients.Get(1);

            Application.Run(pageBrowser);
        }
    }
}
