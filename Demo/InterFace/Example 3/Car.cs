using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterFace.Example_3
{
    internal class Car : Vehicle, IMovable
    {
        public void Backward()
        {
            Console.WriteLine("Car Move Backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car Move Forward");
        }
    }
}
