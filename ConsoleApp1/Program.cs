using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Add two numbers with decimal and round up to nearest int
            double a = 2.3;
            double b = 1.9;
            int c = (int)Math.Ceiling(a + b);
            int d = (int)Math.Floor(a + b);
            Console.WriteLine("round up to int: " + c);
            Console.WriteLine("round to int: " + d);

            //findMedian n within array list

            int[] n= {0,1,2,3,4,5,6};
            int ArrayLength = n.Length;
            int MedianPoint = ArrayLength / 2;
            Console.WriteLine("Median n: " + n[MedianPoint]);
            
        }
    }
    
}
