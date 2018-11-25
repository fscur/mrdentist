using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Presenters
{
    public class PatientHistoryPresenterParams : IPresenterParams
    {
        public Patient Patient { get; set; }
    }
}
