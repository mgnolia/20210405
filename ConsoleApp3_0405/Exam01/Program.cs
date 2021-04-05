using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1inch = 2.54cm
            /*String inch;
            double inchs = 2.54;

            Console.WriteLine("inch : ");
            inch = Console.ReadLine();
            double.Parse (Console.ReadLine());*/
            Console.WriteLine(678);
            //인치를 입력받아서  cm로 구하는 코드 쓰기
            //1 inch = 2.54

            
            
          
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch*2.54+"cm");
            Console.WriteLine(string.Format("{0}cm", inch * 2.54));
            Console.WriteLine($"{inch * 2.54}cm");

            //킬로그램 단위를 입력받아 파운드 단위를 구하는 코드 작성
            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine(pound * 2.20462262 + "pound");
            Console.WriteLine(string.Format("{0}pound", inch * 2.20462262));
            Console.WriteLine($"{inch * 2.20462262}pound");

            //원의 반지름을 입력받아서 원의 둘레와 넓이 구하기
            double r = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            Console.WriteLine("둘레 : "+(r*PI*2));
            Console.WriteLine("둘레 : "+(r*PI*r));

            //4번
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine(one * (two%10)); //첫번째 숫자 곱하기 두번째 숫자의 1의 자리
            Console.WriteLine(one * ((two%100)/10));
            Console.WriteLine(one * (two / 100));
            Console.WriteLine(one * two);


            Console.WriteLine(1/2); // 0
            Console.WriteLine(1.0/2); // 0.5
            Console.WriteLine(1/2.0); // 0.5
            Console.WriteLine(1.0/ 2.0); // 0.5



            Console.WriteLine("문제 제기!!");
            //string sOne = one.ToString();
            string sTwo = two.ToString();//"385"

            //Console.WriteLine('1'-'0');
            //첫번째숫자 곱하기 두번째 숫자의 1의 자리 
            Console.WriteLine(one * int.Parse(sTwo[2].ToString()));
            Console.WriteLine(one * (sTwo[1]-'0'));//56-48
            Console.WriteLine(one * (sTwo[0]-'0'));//51-48


        }
    }
}
