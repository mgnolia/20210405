﻿using System;

namespace Chapter_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if(name=="손우혁")
            {
                //int a = 100;
                Console.WriteLine("마마무 짱");
            }
            else
            {
                Console.WriteLine("9-1=0. 지금은 소녀시대");
            }

            int a = 100;
            if(a>50)
            {
                Console.WriteLine("우와 크다");
                a = -100;
            }
            else
            {
                Console.WriteLine("에이 작네");

            }
            a = 100;
            if (a>50)
            {
                Console.WriteLine("우와 크다");
                a = -100;
            }
            if (a<50)
            {
                Console.WriteLine("에이 작네");
            }

            int number = int.Parse(Console.ReadLine());
            if (number%2==0)
                Console.WriteLine("짝");
            else
                Console.WriteLine("홀");
            
            
            
            
            if (a > 0)
            {
                Console.WriteLine("a의 값이 양수");

                if (a > 50)
                {
                    Console.WriteLine("a의 값이 50초과");
                }
                else
                {
                    Console.WriteLine("a의 값이 50미만");
                }
            }
            else
            {
                Console.WriteLine("a는 음수입니다.");
                if(a>-50)
                {
                    Console.WriteLine("a는 -50보다 큽니다");
                }
                else
                {
                    Console.WriteLine("a는 -50보다 작습니다");

                }

            }

            int b = 100;
            if(b > 50)
            {
                Console.WriteLine("b는 50보다 작습니다");
            }
            else if (b<70)
            {
                Console.WriteLine("b는 70보다 작습니다.");
            }
            else if (b<90)
            {
                Console.WriteLine("b는 90보다 작습니다");
            }
            else
            {
                Console.WriteLine("b의 값은 "+b+"입니다");
            }

            int dice = 3;
            switch (dice)
            {
                case 1:
                    Console.WriteLine("dice : 1");
                    break;
                case 2:
                    Console.WriteLine("dice : 2");
                    break;
                case 3:
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("dice : 4,5,6입니당");
                    break;
                default:
                    Console.WriteLine("1,2,3,4,5,6 중 하나가 아님");
                    break;
            }

            if (dice==1)
                Console.WriteLine("dice : 1");
            else if (dice==2)
                Console.WriteLine("dice : 2");
            else if (dice==3)    
            {

            }
            else if (dice==4||dice==5||dice==6)
            {
                Console.WriteLine("dice : 4,5,6");
            }
            else
            {
                Console.WriteLine("1,2,3,4,5,6 중 하나가 아님");
            }
            //끝에 꼭 else는 안 넣어도 됨

            int KeyCm = 173;
            //키가 170~180애매함
            //if (170<= KeyCm < 180 //이렇게 적으면 안됨
            if (KeyCm >= 170)
            {
                {
                    if (KeyCm < 180)
                        Console.WriteLine("루저인데 애매함");
                }

                if (KeyCm >= 170 && KeyCm < 180)//논리곱 . 하나라도 fale이면 다 fale
                    Console.WriteLine("루저인데 애매함");
                if (KeyCm < 100 || KeyCm > 200) //논리합 . 하나라도 true면 다 true
                    Console.WriteLine("너무 크거나 작다");
            }

            //상항연산자
            //간단한 조건식은 한 줄로 다 표현
            //얘네 둘이 같은 코드임
            a = 2;
            int c = a % 2 == 0 ? -1 : 0;

            if (a % 2 == 0)
                c = -1;
            else
                c = 0;

            //stringdp 특정한 문장 혹은 글자가 있을 때

            string dj = "이동준";
            if (dj.Contains("동")) ;
            Console.WriteLine("동태");
            
            if (dj.Contains("이동")) ;
            Console.WriteLine("Move동");


            int year = int.Parse(Console.ReadLine());
            
            switch (year)
            {
                case 1:
                    Console.WriteLine("자");
                    break;

            }















        }
    }

}
