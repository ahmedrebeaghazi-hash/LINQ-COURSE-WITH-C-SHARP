using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection
{
    internal class EmployeesDTO
    {
        public string Name { set; get; }
        public int EmployeeSkills { set; get; }
        public override string ToString()
        {
            return $"{Name}          {EmployeeSkills}";
        }
    }
}
