using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNetCore.Models {
    public class Employee : Person {
        public int DepartmentId;
        public DateTime HireDate { get; set; }

    }
}
