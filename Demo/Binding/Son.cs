using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class Son : GrandChild
    {
        public int b { get; set; }
        public Son()
        {

        }
        public Son(int x, int y, int z, int a,int b) : base(x, y, z,a)
        {
            this.b = b;
        }
        public new void Print()
        {
            Console.WriteLine("Iam A Son ");
        }
        public override void Display()
        {
            Console.WriteLine("Iam A Son ");
        }
        public override void Func3()
        {
            Console.WriteLine("I am A Son");
        }
    }
}
