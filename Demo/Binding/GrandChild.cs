using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class GrandChild : Child
    {
        public int a { get; set; }
        public GrandChild()
        {

        }
        public GrandChild(int x, int y, int z, int a) : base(x, y, z)
        {
            this.a = a;
        }
        public new void Print()
        {
            Console.WriteLine("Iam A Grand Child ");
        }
        public override void Display()
        {
            Console.WriteLine("Iam A Grand Child ");
        }
        public new virtual void Func3()
        {
            Console.WriteLine("I am A GrandChild");
        }
    }
}
