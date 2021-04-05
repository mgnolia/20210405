using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice0405
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine($"{inch*2.54}cm");



            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine($"{pound*2.20462262}pound");


            double Ban = double.Parse(Console.ReadLine());
            const double PI = 3.14;//PI 상수(대문자가 국룰)
            Console.WriteLine("둘레 : "+2*PI*Ban);
            Console.WriteLine("넓이 : "+3.14*Ban*Ban);

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(a*b);

        }
    }
}
