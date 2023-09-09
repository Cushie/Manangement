using Management.Models;
using Manangement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manangement.CollectionViewModels
{
    public class DoctorCollection
    {
        public RegisterViewModel ApplicationUser { get; set; }
        public Doctor Doctor { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}