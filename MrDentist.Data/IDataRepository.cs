﻿using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Data
{
    public interface IDataRepository
    {
        IExamsDataAccessObject Exams { get; }
        IPatientsDataAccessObject Patients { get; }
        IDentistsDataAccessObject Dentists { get; }
        IAppointmentsDataAccessObject Appointments { get; }
        IPicturesDataAccessObject Pictures { get; }
        IOdontogramsDataAccessObject Odontograms { get; }
        IAddressesDataAccessObject Addresses { get; }
        IUsersDataAccessObject Users { get; }
    }
}
