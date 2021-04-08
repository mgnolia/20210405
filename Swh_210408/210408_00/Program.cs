using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210408_00
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 다섯개의 임의의 숫자를 입력받아 최댓값,최솟값 구하기

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
            }
            Console.WriteLine("min: " + min + " max:" + max);

            //2. 읽고 말하기 수열(개미수열)

            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                //if(i==19)
                Console.WriteLine((i + 1) + " 번째 수열: " + start);
                
                char number = start[0];
                int count = 0;
                string end = "";
                //입력한 수 를 읽음
                for (int j = 0; j < start.Length; j++)
                {
                    if (number==start[j])
                    {
                        count++;
                    }
                    else
                    {
                        //1121 1에서 2로 넘어가는 시점 등
                        end = end + number + count; //1이 2개
                        number = start[j];
                        count = 1;
                    }
                    
                }
                end = end + number + count;
                start = end;
            }

            //3. 별찍기

            Console.WriteLine("3번 문제");
            int inputFoor = int.Parse(Console.ReadLine());
            int Flag = 0;
            if (inputFoor == 1)
                Console.WriteLine("*");
            else
            {
                for (int i = 0; i < inputFoor * 2; i++)
                {
                    for (int j = 0; j < inputFoor; j++)
                    {
                        if (Flag % 2 == 0)
                            Console.Write("*");
                        else
                            Console.Write(" ");

                        Flag++;
                    }
                    if (inputFoor % 2 == 0)
                        Flag++;
                    Console.WriteLine();
                }

            }

            //4. 설탕 배달 문제
            int totalSugar = int.Parse(Console.ReadLine());
            int podae = 0;
            while (true)
            {
                if (totalSugar % 5 == 0)
                {
                    podae += totalSugar / 5;
                    break;
                }

                totalSugar -= 3;
                podae++;

                if (totalSugar < 0)
                {
                    podae = -1;
                    break;
                }
            }
            Console.WriteLine(podae);
        }
    }
}
