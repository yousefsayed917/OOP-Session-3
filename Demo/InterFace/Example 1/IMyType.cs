using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterFace
{
    internal interface IMyType
    {
        //Defualt Access Modifier Is Public
        //What you Can Write In The InterFace
        //1-Signature For Property
        public int salary {  get; set; }
        //2-Signature For Method
        public void MyFunc();
        //C# 8=>
        //Defualt Implemented Method
        public void Print()
        {
            Console.WriteLine("Iam A Defualt Emplemented Method");
        }
    }
}
