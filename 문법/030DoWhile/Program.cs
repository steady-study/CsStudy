using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030DoWhile
{
    //do~while
    //한번 먼저 실행 후 while의 조건이 맞으면 반복.
    /* do
     * {
     *     반복문장;
     * }while(조건절);
     */
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            do
            {
                Console.WriteLine("num : {0}", num++); //이곳에서 num값 증가시켜준다.
            } while (num <= 10);  //do while의 while뒤에는 ';'붙는거 주의.
        }
    }
}
