using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterFace.Example_3
{
    internal class AirPlane : Vehicle, IMovable, IFlyable
    {
        void IMovable.Backward()
        {
            Console.WriteLine("AirPlane Move Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("AirPlane Fly Backward");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("AirPlane Move Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlane Fly Forward");
        }
    }
}
