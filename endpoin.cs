using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision
{
    public class Endpoint
    {
        public static void Greaterorless()
        {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0, x3 = 0, x4 = 0, y3 = 0, y4 = 0;
            double lengthline1 = 0, x = 0, y = 0, a1 = 0, b1 = 0, lengthline2 = 0;

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

            lengthline1 = Math.Sqrt(x + y);
            Console.WriteLine("The length of the first cartesian points are:" + lengthline1);

            Console.WriteLine("Enter values of x3,x4");
            x3 = Convert.ToInt32(Console.ReadLine());
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values of y3,y4");
            y3 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());

            a1 = Math.Pow((x4 - x3), 2);
            b1 = Math.Pow((y4 - y3), 2);
            Console.WriteLine("Length of the line" + a1);
            Console.WriteLine("Length of the line" + b1);

            lengthline2 = Math.Sqrt(a1 + b1);
            Console.WriteLine("The length of the second cartesion points are:" + lengthline2);

            if (lengthline1 == lengthline2)
            {
                Console.WriteLine("Both lines are equal");

            }
            else if (lengthline1 > lengthline2)
            {
                Console.WriteLine("length of line one is greater than second one");
            }
            else if (lengthline2 > lengthline1)
            {
                Console.WriteLine("length of second one is greater than first one");
            }
            else
            {
                Console.WriteLine("Both the lines are not equal to each other");
            }
            Console.ReadLine();
        }

    }
}
