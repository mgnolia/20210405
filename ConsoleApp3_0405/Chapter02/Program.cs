using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1/2);
            Console.WriteLine(1/2.0);
            Console.WriteLine(1.0/2);
            //덧셈 뺄셈 나누기 곱하기 나머지
            Console.WriteLine(5+3);
            Console.WriteLine(5-3);
            Console.WriteLine(5/3);
            Console.WriteLine(5*3);
            Console.WriteLine(5%3);

            Console.WriteLine((5+3)*(5-2));
            //연산의 우선순위를 신경쓰고 싶지 않다면
            //덧셈과 뺄셈을 괄호로 묶었다.
            //그래서 덧셈과 뺄셈을 각각 먼저 하고 곱셈함.

            //문자 선택자

            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[4]);
            /*Console.WriteLine("안녕하세요"[5]);*/
            Console.WriteLine((int)"안녕하세요"[0]);

            Console.WriteLine(1==1);
            Console.WriteLine(1!=1);
            bool result = true;
            bool result2 = false;

            Console.WriteLine(!result); //논리 부정 연산자
            Console.WriteLine(!result2);//논리 부정 연산자

            Console.WriteLine(long.MaxValue) ;
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(1+1); //여기서 1은int로 간주할까? 아님long?
            //-> 기본적으로 숫자는 int 로 인식함

            int a = int.MaxValue;
            int b = int.MaxValue;
            Console.WriteLine(a+b);//오버플로우
            Console.WriteLine((long)a+b);//정상적인 값

            uint c = uint.MaxValue;
            Console.WriteLine(c);

            int example = 100;

            Console.WriteLine(example++); //100 (처리 한 뒤 증가)
            Console.WriteLine(++example); //102 (증가 후 처리)

            int exex = 100;
            Console.WriteLine(exex);
            exex = exex + 1;

            exex = exex + 1;
            Console.WriteLine(exex);

            int conclusion = 100;
            //++을 무조건 뒤에 붙인고 그냥 두줄로 나눠서 쓰기
            conclusion++;//1을 증가시킨뒤
            Console.WriteLine(conclusion);//그 값을 출력
            conclusion++;
            Console.WriteLine(conclusion);

            
        }
    }
}
