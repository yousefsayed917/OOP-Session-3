using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterFace
{
    internal class MyType : IMyType//Emplement The InterFace
    {
        
        public int salary { get; set; }

        public void MyFunc()
        {
            Console.WriteLine("Hi");
        }
    }
}
