using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    internal class CompareTwoLineLength
    {
        public void TwoLineCompare()
        {
            Console.WriteLine("Enter the Co-ordinates of Line 1");
            Console.Write("Enter the value for x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the Co-ordinates of Line 2");
            Console.Write("Enter the value for x3 = ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for y3 = ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for x4 = ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for y4 = ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of The First Line is = " + length1);
            Console.WriteLine("Length of The Second Line is = " + length2);

            if (length1 > length2)
            {
                Console.WriteLine("Length of the 1st Line is Greater than 2nd Line");
            }
            else if (length2 > length1)
            {
                Console.WriteLine("Length of the 2nd Line is Greater than 1st Line");
            }
            else
            {
                Console.WriteLine("Both the Lines are Equals");
            }
        }
    }
}
