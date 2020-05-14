using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029While
{
    //while문.
    /* while(조건절)   조건이 참이면 무한루프. 
     * {
     *     반복문장;
     * }
     */
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i < 101)
            {
                sum += i;   //sum = sum + i     sum = 1/ sum = 4/ sum = 9...
                i = i + 2;  //3  5  7   ... i값이 중가하여 100보다 커지면 while문의 조건이 거짓이 되므로 반복 종료함.
            }
            Console.WriteLine("1~100의 홀수의 합은:{0}", sum);    //sum = 2500

            //while문을 이용한 구구단.
            /*
            int i = 2;
            int j = 1;
            while (i < 10)
            {
                Console.WriteLine("{0}단 ", i);  //2 3 4 5 6 7 8 9
                while (j < 10)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);//2 1/2 2/2 3/...
                    j++;//j = 2/j = 3/j = 4/... j = 9 되면 두번째 while문 반복 종료
                }
                i++;//i = 3
                j = 1;  //j값 초기화 1로 선언 안해주면 j값은 9가 되기 때문에 반복문 종료 됨.
            }
            */
        }
    }
}
