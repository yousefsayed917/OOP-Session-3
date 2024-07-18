using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class Parent
    {
        public int x { get; set; }
        public int y { get; set; }
        public Parent()
        {
            
        }
        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"x : {x}\ny : {y}";
        }
        public void Print()
        {
            Console.WriteLine("I am A Parent");
        }
        public virtual void Display()
        {
            Console.WriteLine("I am A Parent");
        }
        public virtual void Func3()
        {
            Console.WriteLine("I am A Parent");
        }
    }
}
