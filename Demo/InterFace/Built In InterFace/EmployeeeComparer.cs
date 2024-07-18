using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterFace.Built_In_InterFace
{
    internal class EmployeeeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employeee? employeeex = (Employeee?)x;
            Employeee? employeeey = (Employeee?)y;
            return employeeex?.Name!.CompareTo(employeeey?.Name) ?? (employeeey is null ? 0 : -1);
        }
    }
}
