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
            int[] n= {7,6,0,1,2,3,4};
            Array.Sort(n);
            int ArrayLength = n.Length;
            int MedianPoint = ArrayLength / 2;
            Console.WriteLine("Median n: " + n[MedianPoint]);
            
            //sequence sum
            int i=0; //0, 1, 2, 3, 4, 5 = 15
            int j=5; //4, 3, 2, 1, 0 = 10
            int k=1; //total shld be: 15 + 10 + 1 = 26

            int sum = 0;
            for (i = 0; i<= j; i++)
            {
                    sum +=i; 
            }

            Console.WriteLine("sum of i = " +sum);
            int sum2 = 0;
            for (j=5;j>i;j--)
            {
                sum2 +=j; 
            }
            Console.WriteLine("sum of j = " + sum2);



        }
    }
    
}
