using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision
{
    public class Equality
    {
        public static void Equal()
        {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            double length = 0, x = 0, y = 0;

            Console.WriteLine("Enter values of x1,x2");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values of y1,y2");
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            x = Math.Pow((x2 - x1), 2);
            y = Math.Pow((y2 - y1), 2);
            Console.WriteLine("Length of the line:" + x);
            Console.WriteLine("Length of the line:" + y);

            length = Math.Sqrt(x + y);
            Console.WriteLine("The length of the cartesion points is:" + length);

            if (x == y)
            {
                Console.WriteLine("Both the lines are equal");

            }
            else
            {
                Console.WriteLine("Both the lines are not equal");
            }
        }
    }
}
