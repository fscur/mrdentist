using MrDentist.Data;
using MrDentist.Data.Memory;
using MrDentist.Data.MongoDB;
using MrDentist.Models;
using MrDentist.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MrDentist.DesktopApp
{
    static class Program
    {
        private static IDataRepository repository;

        private static void InitFakeData(User user)
        {
            var dentist0 = new Dentist(0)
            {
                Name = "Dentalino Almeida",
                Address = new Address(0) { Description = "Rua João Betega, 1340 - Apto. 501" },
                Phones = new List<string>() { "+5554996894581" },
                ProfessionalRegister = "1099",
                User = user
            };

            var dentist1 = new Dentist(1)
            {
                Name = "Floriano Marciano",
                Address = new Address(1) { Description = "Avenida Julio de Castilhos, 100" },
                Phones = new List<string>() { "+5554332222211" },
                ProfessionalRegister = "1111"
            };

            var patient0 = new Patient(0)
            {
                Name = "Mario Zamelao",
                Address = new Address(2) { Description = "Rua Sinimbu, 30" },
                Phones = new List<string>() { "+5554996894581" },
                BloodType = "AB+",
                InsuranceNumber = "188726663",
                Dentist = dentist0
            };

            var date1 = new DateTime(2018, 7, 2);
            var odontogramEntry1 = new OdontogramEntry(0)
            {
                Date = date1
            };

            odontogramEntry1.DentalIssues.Add(new Cavity(0, new Models.PointF(100, 250)));

            var odontogram1 = new Odontogram(0)
            {
                BaseImage = System.Drawing.Image.FromFile("odontogramimages\\odontogram.jpg")
            };

            odontogram1.Entries.Add(odontogramEntry1);

            var patient1 = new Patient(1)
            {
                Name = "Maria de Deus",
                Address = new Address(3) { Description = "Avenida Julio de Castilhos, 100" },
                Phones = new List<string>() { "+5554332222211" },
                BloodType = "O-",
                InsuranceNumber = "188726663",
                Dentist = dentist0,
                Odontogram = odontogram1
            };

            dentist0.Patients.Add(patient0);
            dentist0.Patients.Add(patient1);

            repository.Patients.Add(patient0);
            repository.Patients.Add(patient1);
            repository.Dentists.Add(dentist0);
            repository.Dentists.Add(dentist1);

            repository.Appointments.Add(new Appointment(0)
            {
                Attended = true,
                Date = new DateTime(2018, 7, 2),
                Dentist = repository.Dentists.Get(0),
                Patient = repository.Patients.Get(0),
                Observations = "O dente caiu da boca."
            });

            repository.Appointments.Add(new Appointment(1)
            {
                Attended = true,
                Date = date1,
                Dentist = repository.Dentists.Get(0),
                Patient = repository.Patients.Get(1),
                Observations = "O dente estava podre.",
                OdontogramEntry = odontogramEntry1
            });

            repository.Appointments.Add(new Appointment(2)
            {
                Attended = true,
                Date = new DateTime(2018, 9, 22),
                Dentist = repository.Dentists.Get(0),
                Patient = repository.Patients.Get(1),
                Observations = "O dente estava mais podre."
            });
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            repository = new MongoDataRepository("mongodb://localhost:27017");
            User loggedUser = repository.Users.Get(0);

            //InitFakeData(loggedUser);

            var patientHistoryPage = new PatientHistoryPage();
            var patientHistoryPresenter = new PatientHistoryPresenter(repository, patientHistoryPage);

            var odontogramEntryPage = new OdontogramEntryPage();
            var odontogramEntryPresenter = new OdontogramEntryPresenter(repository, odontogramEntryPage);

            var pageBrowser = new PageBrowser(patientHistoryPage);

            patientHistoryPresenter.OdontogramEntryPageRequested += (s, e) =>
            {
                odontogramEntryPresenter.OdontograEntry = e.Entry;
                odontogramEntryPresenter.SetOdontogramImage(e.Odontogram.BaseImage);
                pageBrowser.OpenPage(odontogramEntryPage);
            };

            patientHistoryPresenter.Patient = repository.Patients.Get(1);

            Application.Run(pageBrowser);
        }
    }
}
