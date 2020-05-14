using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033Continue
{
    //continue는 break와 반대기능 수행. 
    //해당문의 시작 지점으로 제어를 이동시킴. 예를들어 반복문에서 continue문을 만나면 반복문의 시작점으로 제어 이동
    class Program
    {
        
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) //i를 2로 나눈 나머지 값이 0이면, 다시 for문 처음으로 돌아감. 2의 배수.
                    continue;
                sum += i;   //2의 배수가 아니면 continue건너뛰고 이 식을 수행하기 됨.
                Console.Write(i + "\n");
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
