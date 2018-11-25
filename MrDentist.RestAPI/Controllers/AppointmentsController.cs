using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MrDentist.Data.DTOs;
using MrDentist.Data.MongoDB.DTOs;
using MrDentist.Models;
using MrDentist.Models.Extensions;
using Swashbuckle.Swagger.Annotations;

namespace MrDentist.RestAPI.Controllers
{
    public class AppointmentsController : ApiController
    {
        MrDentist.Data.MongoDB.MongoDataRepository repository;

        public AppointmentsController()
        {
            //System.Configuration.Configuration rootWebConfig =
            //    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MrDentistRestAPI");
            //System.Configuration.ConnectionStringSettings connString = null;

            //if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
            //{
            //    connString =
            //        rootWebConfig.ConnectionStrings.ConnectionStrings["LocalMongo"];
            //    if (connString != null)
            //        Console.WriteLine("Northwind connection string = \"{0}\"",
            //            connString.ConnectionString);
            //    else
            //        Console.WriteLine("No Northwind connection string");
            //}

            //var connectionString = ConfigurationManager.ConnectionStrings["LocalMongo"].ConnectionString;
            //"mongodb://mrdentist:R5oUrEPPRLrzt4kRk4hXwsdMEqpJsyXwsSFmkrq38zumTjd4I2SaeYktBC8J2chAOiVhiP9SbFEXKMNXXXn6jA==@mrdentist.documents.azure.com:10255/?ssl=true&replicaSet=globaldb"
            repository = new MrDentist.Data.MongoDB.MongoDataRepository("mongodb://mrdentist:R5oUrEPPRLrzt4kRk4hXwsdMEqpJsyXwsSFmkrq38zumTjd4I2SaeYktBC8J2chAOiVhiP9SbFEXKMNXXXn6jA==@mrdentist.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
            //repository = new MrDentist.Data.MongoDB.MongoDataRepository("mongodb://localhost:27017");
        }

        // GET api/values
        [SwaggerOperation("GetAll")]
        public IEnumerable<IAppointmentDTO> Get()
        {
            foreach (var appointment in repository.Appointments.All)
            {
                yield return appointment.ToDto();
            }
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IAppointmentDTO Get(int id)
        {
            return repository.Appointments.Get(id).ToDto();
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]IAppointmentDTO value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]IAppointmentDTO value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
