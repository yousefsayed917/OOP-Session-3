using Demo.Binding;
using Demo.InterFace;
using Demo.InterFace.Built_In_InterFace;
using Demo.InterFace.Example_3;
using System.Reflection.Metadata;

namespace Demo
{
    internal class Program
    {
        #region Binding Func
        public static void ProcessEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.Func1();//static binding 
                employee.Func2();//dynamic binding
            }
        }
        #endregion
        #region InterFace Func
        public static void Print(ISeries series)
        {
            if (series == null)
                return;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}\t");
                series.GetNext();
            }
            series.Reset();
        }

        #endregion


        static void Main(string[] args)
        {
            #region What Is Binding?
            //Binding Is A Behaviour 
            //Reference from Parent = New Object From Child
            //Parent RefParent = new Child();//this is only way to emplement the binding
            //RefParent.x = 1;
            //RefParent.y = 2;
            ////RefParent.z = 3; Invalid 
            //RefParent.Print(); // I am A Parent //because this method is overriden by new [Early Binding]
            //RefParent.Display();// I am A Child //because this method is overriden by override [Late Binding]
            //Child RefChild = (Child)RefParent;//not binding this is Explicit casting
            #endregion
            #region Binding Example 1
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee() { id = 10, name = "yousef", age = 22, salary = 20000 };
            // //ProcessEmployee(fullTimeEmployee);
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee() { id = 10, name = "yousef", age = 22, HourRate = 120 };
            //ProcessEmployee(partTimeEmployee);
            #endregion
            #region Binding Example 2
            //Parent parent = new GrandChild();
            //parent.Print();//static Binding
            //parent.Display();//Dynamic Binding
            //Child child = new GrandChild();
            //child.Print();//static Binding//Iam A Child
            //child.Display();//dynamic Binding// Iam A Grand Child
            // Parent p = new Son();
            // p.Func3();
            // Child c = new Son();
            // c.Func3();
            // GrandChild gc = new Son();
            // gc.Func3();
            //Son s = new Son();
            // s.Func3();
            #endregion
            #region InterFace
            #region Example 1
            // IMyType myType;
            // Declare Reference Of Type "IMyType" Refering To Null
            // this Reference Can Refer To An Object From Class Or Struct That Emplement This InterFace
            // CLR Will Allocate 4 Bytes At Stack For The Reference
            // myType = new IMyType();//Invalid Can Not Create An Object From InterFace
            // MyType myType1 = new MyType();
            // myType1.salary = 10000;
            // myType.Print();// invalid 
            // IMyType type = new MyType();
            // type.Print();
            #endregion
            #region Example 2
            //Series series = new Series();
            //Print(series);
            //Series2 series2 = new Series2();
            //Print(series2);
            #endregion
            #region Example 3
            //AirPlane airPlane=new AirPlane();
            //airPlane.Forward();//invalid
            //IMovable movable = new AirPlane();
            //movable.Backward();
            //IFlyable flyable = new AirPlane();
            //flyable.Backward();
            #endregion
            #endregion
            #region Shallow Copy
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //Console.WriteLine($"Hash Code Of Arr1 : {arr1.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Arr2 : {arr2.GetHashCode()}");
            //arr2 = arr1;
            //Object {1,2,3} Has To References [arr1 , arr2]
            //Object {4,5,6} Became Unreachable Object 
            //this is Shallow copy
            //Console.WriteLine("after Shallow copy");
            //Console.WriteLine($"Hash Code Of Arr1 : {arr1.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Arr2 : {arr2.GetHashCode()}");
            #endregion
            #region Deep Cpoy
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //Console.WriteLine($"Hash Code Of Arr1 : {arr1.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Arr2 : {arr2.GetHashCode()}");
            //arr2 = (int[])arr1.Clone(); 
            //Clone Method will Generate New Object With New Identity
            //This Object Will Have The Same Object.Data Of Called Object [arr1]
            //Console.WriteLine("after Deep copy");
            //Console.WriteLine($"Hash Code Of Arr1 : {arr1.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Arr2 : {arr2.GetHashCode()}");
            //arr1[0] = 100;
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr1[0]);
            #endregion
            #region IClonable
            //Employeee employeee1 = new Employeee() { Id = 1, Name = "yousef", Salary = 20000 };
            //Employeee employeee2 = new Employeee() { Id = 2, Name = "mohamed", Salary = 30000 };
            //Console.WriteLine($"HashCode Of Employeee1 {employeee1.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Employeee2 {employeee2.GetHashCode()}");
            //employeee2 = (Employeee)employeee1.Clone();//Deep Copy
            //Console.WriteLine($"HashCode Of Employeee1 {employeee1.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Employeee2 {employeee2.GetHashCode()}");
            #endregion
            #region Copy Constructor
            //Employeee employeee1 = new Employeee() { Id = 1, Name = "yousef", Salary = 20000 };
            //Console.WriteLine($"HashCode Of Employeee1 {employeee1.GetHashCode()}");
            //Employeee employeee2 = new Employeee(employeee1);
            //Console.WriteLine($"HashCode Of Employeee1 {employeee1.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Employeee2 {employeee2.GetHashCode()}");
            #endregion
            #region ICompareable
            //int[] arr1 = { 3,6,9,7,5,4,1 };
            //Array.Sort(arr1);
            //foreach (int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            //Employeee[] employeees =
            //{
            //    new Employeee(){Id=1,Name="yousef",Salary=50000},
            //    new Employeee(){Id=2,Name="mohamed",Salary=30000},
            //    new Employeee(){Id=3,Name="ahmed",Salary=20000},
            //    new Employeee(){Id=4,Name="soso",Salary=40000}
            //};
            //int result = employeees[0].CompareTo(employeees[1]);
            //Console.WriteLine(result);
            //foreach (var item in employeees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region IComparer
            Employeee[] employeees =
           {
                new Employeee(){Id=1,Name="yousef",Salary=50000},
                new Employeee(){Id=2,Name="mohamed",Salary=30000},
                new Employeee(){Id=3,Name="ahmed",Salary=20000},
                new Employeee(){Id=4,Name="soso",Salary=40000}
            };
            Array.Sort(employeees, new EmployeeeComparer());
            foreach (Employeee item in employeees)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
