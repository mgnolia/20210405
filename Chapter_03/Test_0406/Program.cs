using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_0406
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = int.Parse(Console.ReadLine());
            switch (birthYear%12)
            {
                case 0:
                    Console.WriteLine("몽치");
                    break;
                case 1:
                    Console.WriteLine("키키");
                    break;
                case 2:
                    Console.WriteLine("강다리");
                    break;
                case 3:
                    Console.WriteLine("찡찡이");
                    break;
                case 4:
                    Console.WriteLine("똘기");
                    break;
                case 5:
                    Console.WriteLine("떵이");
                    break;
                case 6:
                    Console.WriteLine("호치");
                    break;
                case 7:
                    Console.WriteLine("새초미");
                    break;
                case 8:
                    Console.WriteLine("드라고");
                    break;
                case 9:
                    Console.WriteLine("요롱이");
                    break;
                case 10:
                    Console.WriteLine("마초");
                    break;
                case 11:
                    Console.WriteLine("미미");
                    break;

                default:
                    Console.WriteLine("Who are you");
                    break;
            }
            int month = int.Parse(Console.ReadLine());
            switch (month)

            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter is coming");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring is coming");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer is coming");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Fall is coming");
                    break;
                default:
                    Console.WriteLine("Nothing is coming");
                    break;
            }

            //3번 알람문제

            Console.WriteLine("H?");
                int H = int.Parse(Console.ReadLine());
            Console.WriteLine("M?");
                int M = int.Parse(Console.ReadLine());
            Console.WriteLine($"내가 맞춘 시간: {H}시 {M}시");
            M -= 45;

            if (M<0)
            {
                M += 60;
                H -= 1;
            }
            if (H < 0)
                H += 24;

            Console.WriteLine($"알람시간 설정 완료\n" +
                $"H : {H}{Environment.NewLine}" + 
                $"M : {M}\n");
            Console.ReadLine();

            Console.ReadLine();


        }
    }
}
