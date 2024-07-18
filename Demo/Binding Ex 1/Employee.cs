using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class Employee
    {
        public int id {  get; set; }
        public string? name { get; set; }
        public int age {  get; set; }
        public void Func1()
        {
            Console.WriteLine("Iam Employee");
        }
        public virtual void Func2()
        {
            Console.WriteLine($"Employee :Id {id} , Name {name} , Age {age}");
        }
    }
}
