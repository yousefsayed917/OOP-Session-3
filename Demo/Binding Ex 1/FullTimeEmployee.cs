using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal salary { get; set; }
        public new void Func1()
        {
            Console.WriteLine("Iam Full Time Employee");
        }
        public override void Func2()
        {
            Console.WriteLine($"Employee :Id {id} , Name {name} , Age {age} , Salary{salary}");
        }
    }
}
