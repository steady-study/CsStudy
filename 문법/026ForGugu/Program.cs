using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026ForGugu
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i < 10; i++) //첫번째for문
            {                
                Console.WriteLine("{0}단 : \t", i);//2부터 9까지 찍힘.

                for(int j = 1; j < 10; j++) //두번째 for문
                {
                    //1부터 9까지
                    Console.WriteLine("{0} * {1} = {2}", i, j,i*j);
                    //                  2     1     
                    //                        2
                    //                        3
                    //                       ...
                    //                        9 까지 다 돌면 두번째 for문 빠져나가고, 
                    //                          첫번째for문의 조건에 또 걸려서 다시 들어오게됨.
                }
            }
        }
    }
}
