using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class Child : Parent
    {
        public int z { get; set; }
        public Child()
        {

        }
        public Child(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return $"x : {x}\ny : {y}\nz : {z}";
        }
        // Override using (new) New Virsion from Print()
        // static Binding [Early Binding]
        // CLR Will Bind The Function Call Based On Reference Not Object
        // At Compilation Time 
        public new void Print() 
        {
            Console.WriteLine("I am A Child");
        }
        // override using override (parent's Method is public virtual)
        // Dynamic Binding [Late Binding]
        // CLR Will Bind The Function Call Based On Object Not Reference
        // At Run Time
        public override void Display() 
        {
            Console.WriteLine("I am A Child");
        }
        public override void Func3()
        {
            Console.WriteLine("I am A Child");
        }
    }
}
