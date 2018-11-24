using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrDentist.RestAPI.Client;
using MrDentist.Models;
using MrDentist.Data;
using MrDentist.Data.MongoDB;

namespace MrDentist.ConsoleTest
{
    class Program
    {
        static DateTime date0 = (new DateTime(2018, 3, 10)).ToUniversalTime();
        static DateTime date1 = (new DateTime(2018, 7, 2)).ToUniversalTime();
        static DateTime date2 = (new DateTime(2018, 10, 1)).ToUniversalTime();
        static DateTime date3 = (new DateTime(2018, 12, 9)).ToUniversalTime();

        static void Main(string[] args)
        {
            var repository = new MrDentist.Data.MongoDB.MongoDataRepository("mongodb://localhost:27017");

            var users = CreateFakeUsers(repository);
            var addresses = CreateFakeAddresses(repository);
            var odontograms = CreateFakeOdontograms(repository);
            var dentists = CreateFakeDentists(repository);
            var patients = CreateFakePatients(repository);
            var appointments = CreateFakeAppointments(repository);

            foreach (var item in repository.Patients.All.ToList())
            {
                Console.WriteLine(item.Name);
            }

            Console.Read();
        }

        private static IEnumerable<User> CreateFakeUsers(MongoDataRepository repository)
        {
            if (repository.Users.Get(0) != null)
                return repository.Users.All;

            repository.Users.Add(new User(0, "filipe.scur", string.Empty, UserType.Dentist));

            return repository.Users.All;
        }

        private static IEnumerable<Dentist> CreateFakeDentists(MongoDataRepository repository)
        {
            if (repository.Dentists.Get(0) != null)
                return repository.Dentists.All;

            var dentist = new Dentist(0)
            {
                Name = "Filipe",
                Address = repository.Addresses.Get(0),
                Phones = new List<string>() { "+5554996894581" },
                User = repository.Users.Get(0),
                ProfessionalRegister = "1928282820"
            };

            repository.Dentists.Add(dentist);

            return repository.Dentists.All;
        }

        private static IEnumerable<Patient> CreateFakePatients(IDataRepository repository)
        {
            if (repository.Patients.Get(0) != null)
                return repository.Patients.All;

            var patient0 = new Patient(0)
            {
                Name = "Mario Zamelao",
                Address = repository.Addresses.Get(0),
                Phones = new List<string>() { "+5554996894581" },
                BloodType = "AB+",
                InsuranceNumber = "188726663",
                Dentist = repository.Dentists.Get(0),
                Picture = new Picture() { Id = 0, Image = null, Url = string.Empty }
            };

            var patient1 = new Patient(1)
            {
                Name = "Maria de Deus",
                Address = repository.Addresses.Get(1),
                Phones = new List<string>() { "+5554332222211" },
                BloodType = "O-",
                InsuranceNumber = "188726663",
                Dentist = repository.Dentists.Get(0),
                Odontogram = repository.Odontograms.Get(1)
            };

            repository.Patients.Add(patient0);
            repository.Patients.Add(patient1);

            patient0.Dentist.Patients.Add(patient0);
            patient1.Dentist.Patients.Add(patient1);

            return repository.Patients.All;
        }

        private static IEnumerable<Address> CreateFakeAddresses(IDataRepository repository)
        {
            if (repository.Addresses.Get(0) != null)
                return repository.Addresses.All;
            
            repository.Addresses.Add(new Address(0) { Description = "Rua João Betega, 1340 - Apto. 501" });
            repository.Addresses.Add(new Address(1) { Description = "Rua Julio de Castilhos, 192" });

            return repository.Addresses.All;
        }

        private static IEnumerable<Odontogram> CreateFakeOdontograms(IDataRepository repository)
        {
            if (repository.Odontograms.Get(0) != null)
                return repository.Odontograms.All;

            var odontogramimageurl = @"D:\Drive\study\UCS\CS\2018-4\Projeto e Arquitetura\Trabalho Dentistas\mrdentist\images\odontogram.jpg";

            var odontogram0 = new Odontogram(0)
            {
                BaseImage = System.Drawing.Image.FromFile(odontogramimageurl),
                BaseImageUrl = odontogramimageurl
            };

            var odontogram1 = new Odontogram(1)
            {
                BaseImage = System.Drawing.Image.FromFile(odontogramimageurl),
                BaseImageUrl = odontogramimageurl
            };

            var odontogramEntry0 = new OdontogramEntry(0)
            {
                Date = date0,
            };

            odontogramEntry0.DentalIssues.Add(new Cavity(0, new Models.PointF(50, 70)));

            var odontogramEntry1 = new OdontogramEntry(1)
            {
                Date = date1,
            };

            odontogramEntry1.DentalIssues.Add(new Cavity(1, new Models.PointF(100, 50)));

            var odontogramEntry2 = new OdontogramEntry(2)
            {
                Date = date2,
            };

            odontogramEntry2.DentalIssues.Add(new Cavity(2, new Models.PointF(140, 190)));

            var odontogramEntry3 = new OdontogramEntry(3)
            {
                Date = date3,
            };

            odontogramEntry3.DentalIssues.Add(new Cavity(3, new Models.PointF(20, 30)));

            odontogram0.Entries.Add(odontogramEntry0);
            odontogram1.Entries.Add(odontogramEntry1);
            odontogram1.Entries.Add(odontogramEntry2);
            odontogram1.Entries.Add(odontogramEntry3);

            repository.Odontograms.Add(odontogram0);
            repository.Odontograms.Add(odontogram1);

            return repository.Odontograms.All;   
        }

        private static IEnumerable<Appointment> CreateFakeAppointments(IDataRepository repository)
        {
            if (repository.Appointments.Get(0) != null)
                return repository.Appointments.All;

            repository.Appointments.Add(new Appointment(0)
            {
                Attended = true,
                Date = date0,
                Dentist = repository.Dentists.Get(0),
                Patient = repository.Patients.Get(0),
                Observations = "O dente caiu da boca."
            });

            var patient1 = repository.Patients.Get(1);

            var entry0 = repository.Odontograms.GetOdontogramEntry(patient1.Odontogram.Id, date1);
            var entry1 = repository.Odontograms.GetOdontogramEntry(patient1.Odontogram.Id, date2);
            var entry2 = repository.Odontograms.GetOdontogramEntry(patient1.Odontogram.Id, date3);

            repository.Appointments.Add(new Appointment(1)
            {
                Attended = true,
                Date = date1,
                Dentist = repository.Dentists.Get(0),
                Patient = patient1,
                Observations = "O dente estava podre.",
                OdontogramEntry = entry0
            });

            repository.Appointments.Add(new Appointment(2)
            {
                Attended = true,
                Date = date2,
                Dentist = repository.Dentists.Get(0),
                Patient = patient1,
                Observations = "O dente estava mais podre.",
                OdontogramEntry = entry1
            });

            repository.Appointments.Add(new Appointment(3)
            {
                Attended = true,
                Date = date3,
                Dentist = repository.Dentists.Get(0),
                Patient = repository.Patients.Get(1),
                Observations = "O dente caiu da boca.",
                OdontogramEntry = entry2
        });

            return repository.Appointments.All;
        }

        static void RestTest(string[] args)
        {
            var baseUri = new Uri("https://mrdentistrestapi20181120091246.azurewebsites.net");
            var client = new MrDentistRestAPI(baseUri);
            var response = client.GetAllAsync().Result;
        }
    }
}

