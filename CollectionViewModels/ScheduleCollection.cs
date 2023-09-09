using Management.Models;
using Manangement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manangement.CollectionViewModels
{
    public class ScheduleCollection
    {
        public Schedule Schedule { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}