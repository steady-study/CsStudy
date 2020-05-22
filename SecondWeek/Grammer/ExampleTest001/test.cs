using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTest001
{
    class test
    {
        static void Main(string[] args)
        {
            //1~500까지 3의 배수이면서 7의 배수인 숫자의 총합 구하기.
            int sum = 0;

            for (int i = 0; i <500; i++)
            {
                if(i % 3 == 0 & i%7 == 0)
                {
                    sum += i;                    
                }
            }
            Console.WriteLine("1~500까지 3의배수이면서 7의 배수인 숫자의 총합 : {0}", sum);


            //10진수 세개들 args[] 값으로 입력받아 2진수로 출력하는 프로그램 작성.
        }
    }
}
