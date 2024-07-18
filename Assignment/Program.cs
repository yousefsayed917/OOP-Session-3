using Assignment.Project_1;
using Assignment.Project_2;
using Assignment.Project_3;

namespace Assignment
{
    internal class Program
    {
        #region Project 1 Func
        public static Point_3D ReadPoint()
        {
            int x, y, z;
            do
            {
                Console.Write("Enter x coordinate: ");
            } while (!int.TryParse(Console.ReadLine(), out x));

            Console.Write("Enter y coordinate: ");
            y = int.Parse(Console.ReadLine()!);

            Console.Write("Enter z coordinate: ");
            z = Convert.ToInt32(Console.ReadLine()!);

            return new Point_3D(x, y, z);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Project 1
            //Console.WriteLine("Enter coordinates for point P1:");
            //Point_3D p1 = ReadPoint();
            //Console.WriteLine("Enter coordinates for point P2:");
            //Point_3D p2 = ReadPoint();
            //Console.WriteLine("-------------------");
            ////if (p1 == p2) // Doesn't work
            ////{
            ////    Console.WriteLine("yousef");
            ////}
            //Point_3D[] points=new Point_3D[] 
            //{
            //    new Point_3D(1,4,3),
            //    new Point_3D(4,2,8),
            //    new Point_3D(2,6,6),
            //    new Point_3D(6,1,2),
            //    new Point_3D(6,7,3),
            //    new Point_3D(2,3,3)
            //};
            //Array.Sort(points);
            //foreach (Point_3D item in points)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //p2 = (Point_3D)p1.Clone();
            #endregion
            #region Project 2
            //int num1 = 10;
            //int num2 = 5;
            //Console.WriteLine($"Add: {num1} + {num2} = {Maths.Add(num1, num2)}");
            //Console.WriteLine($"Subtract: {num1} - {num2} = {Maths.Subtract(num1, num2)}");
            //Console.WriteLine($"Multiply: {num1} * {num2} = {Maths.Multiply(num1, num2)}");
            //Console.WriteLine($"Divide: {num1} / {num2} = {Maths.Divide(num1, num2)}");
            #endregion
            #region Project 3
            //Duration duration1 = new Duration(1, 30, 45);
            //Duration duration2 = new Duration(1, 30, 45);

            //Console.WriteLine($"duration1 equals duration3: {duration1.Equals(duration2)}");
            //Console.WriteLine($"Hash code of duration1: {duration1.GetHashCode()}");

            //Duration duration = new Duration(666);
            //Console.WriteLine(duration.ToString());

            //Duration duration3 = duration1 + duration2;
            //Console.WriteLine(duration3.ToString());

            //Duration duration4 = duration1 + 7800;
            //Console.WriteLine(duration3.ToString());

            //duration3 =duration3 +666;
            //Console.WriteLine(duration3.ToString());

            #endregion

        }
    }
}
