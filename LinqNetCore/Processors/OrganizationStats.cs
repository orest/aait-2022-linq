using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqNetCore.Data;
using LinqNetCore.Models;

namespace LinqNetCore.Processors
{
    public class OrganizationStats
    {
        private List<Employee> Employees { get; set; }

        public OrganizationStats()
        {
            var context = new DataContext();
            Employees = context.Employees;
        }



        public int GetTotalEmployeeCount()
        {
            return Employees.Count;

        }
    }
}
