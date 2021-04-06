using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_0406
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = int.Parse(Console.ReadLine());
            switch (birthYear%12)
            {
                case 0:
                    Console.WriteLine("원숭이 띠");
                    break;
                case 1:
                    Console.WriteLine("닭 띠");
                    break;
                case 2:
                    Console.WriteLine("개 띠");
                    break;
                case 3:
                    Console.WriteLine("돼지 띠");
                    break;
                case 4:
                    Console.WriteLine("쥐 띠");
                    break;
                case 5:
                    Console.WriteLine("소 띠");
                    break;
                case 6:
                    Console.WriteLine("호랑이 띠");
                    break;
                case 7:
                    Console.WriteLine("토끼 띠");
                    break;
                case 8:
                    Console.WriteLine("용 띠");
                    break;
                case 9:
                    Console.WriteLine("뱀 띠");
                    break;
                case 10: 
                    Console.WriteLine("말 띠");
                    break;
                case 11:
                    Console.WriteLine("양 띠");
                    break;
                default:
                    Console.WriteLine("who are you");
                    break;


            }

            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("winter is coming");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("spring is coming");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("summer is coming");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("fall is coming");
                    break;
                default:
                    Console.WriteLine("nothing is coming");
                    break;

            }








            
        }
    }
}
