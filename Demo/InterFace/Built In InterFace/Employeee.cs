using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterFace.Built_In_InterFace
{
    internal class Employeee : ICloneable , IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employeee() { }
        //Copy Constructor //Deep Copy
        public Employeee(Employeee employeeeCopy) 
        {
            this.Id = employeeeCopy.Id;
            this.Name =employeeeCopy. Name;
            this.Salary = employeeeCopy.Salary;
        }

        public object Clone()
        {
            return new Employeee(this);
            //{ Id=this.Id, Name=this.Name, Salary=this.Salary};//this.Salary for the Caller
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employeee? compareemployeee = (Employeee?)obj;
            if (this.Salary > compareemployeee?.Salary)
                return 1;
            else if (this.Salary < compareemployeee?.Salary)
                return -1;
            else
                return 0;

        }
    }
}
