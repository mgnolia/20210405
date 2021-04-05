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
            //inch => cm 변환
            Console.WriteLine("inch");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine($"{inch*2.54}cm");


            //kg => pound 변환
            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine($"{pound*2.20462262}pound");

            //원의 반지름을 입력받아서 원의 둘레와 넓이 구하기
            double Ban = double.Parse(Console.ReadLine());
            const double PI = 3.14;//PI 상수(대문자가 국룰)
            Console.WriteLine("둘레 : "+2*PI*Ban);
            Console.WriteLine("넓이 : "+3.14*Ban*Ban);
            //4번 472*385(사실 몇이랑 몇 곱하는 문제인지 기억안나서 정확하진 않아요)
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string bb = b.ToString();

            Console.WriteLine(a * int.Parse(bb[2].ToString()));
            Console.WriteLine(a * int.Parse(bb[1].ToString()));
            Console.WriteLine(a*b);

        }
    }
}
