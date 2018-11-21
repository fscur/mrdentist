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
        IDataAccessObject<Patient> Patients { get; }
        IDataAccessObject<Dentist> Dentists { get; }
        IDataAccessObject<Appointment> Appointments { get; }
    }
}
