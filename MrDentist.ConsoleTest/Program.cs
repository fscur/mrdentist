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
        static void Main(string[] args)
        {
            var repository = new MrDentist.Data.MongoDB.MongoDataRepository("mongodb://localhost:27017");

            var users = CreateFakeUsers(repository);
            var addresses = CreateFakeAddresses(repository);
            var dentists = CreateFakeDentists(repository);
            var patients = CreateFakePatients(repository);

            foreach (var item in repository.Patients.All.ToList())
            {
                Console.WriteLine(item.Name);
            }
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
                Odontogram = repository.Odontograms.GetByPatientId(1)
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

        static void RestTest(string[] args)
        {
            var baseUri = new Uri("https://mrdentistrestapi20181120091246.azurewebsites.net");
            var client = new MrDentistRestAPI(baseUri);
            var response = client.GetAllAsync().Result;
        }
    }
}
