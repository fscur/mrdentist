using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrDentist.RestAPI.Client;
using MrDentist.Models;

namespace MrDentist.ConsoleTest
{
    class Program
    {
        static void Main(string[] args) {

            User user = new User(0, "filipe.scur", string.Empty, UserType.Dentist);

            var dentist0 = new Dentist()
            {
                Id = 0,
                Name = "Dentalino Almeida",
                Address = new Address() { Description = "Rua João Betega, 1340 - Apto. 501" },
                Phones = new List<string>() { "+5554996894581" },
                ProfessionalRegister = 1099,
                User = user
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

            var repo = new MrDentist.Data.MongoDB.MongoDataRepository("mongodb://localhost:27017");

            //repo.Patients.Add(patient0);

            foreach (var item in repo.Patients.All)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void RestTest(string[] args)
        {
            var baseUri = new Uri("https://mrdentistrestapi20181120091246.azurewebsites.net");
            var client = new MrDentistRestAPI(baseUri);
            var response = client.GetAllAsync().Result;
        }
    }
}
