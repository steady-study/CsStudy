using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//짝수 시마다 문자출력
namespace _001ContinueBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] am = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            int[] pm = new int[] {13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            for (int i = 0; i<am.Length; i++)
            {
                if(i%2 != 0)
                {
                    continue;                   
                }
                else
                {
                    for(int k = 1; k<7; k++)
                    {
                        Console.WriteLine("무음:{0}시 입니다...Zzzz", am[k]);

                        break;
                    }
                    Console.WriteLine("땡 땡 땡 똉!!!!!!!!!!!!!! {0}시!!",am[i] );
                    
                }
                Console.WriteLine();
            }
            for(int j = 1; j<pm.Length; j++)
            {
                if(j % 2 != 0)
                {
                    continue;
                }
                else
                {
                    while(true)
                        if (j < 18)
                        {
                            Console.WriteLine("땡 땡 땡 땡 {0}시 입니다", pm[j]);
                            break;
                        }
                        else if(j>18 && j< 22)
                        {
                            Console.WriteLine("땡 땡 땡 {0}시 입니다. 잠자리에 들 준비를 하세요", pm[j]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("무음 : {0}시 입니다." ,pm[j]);
                            break;
                        }                        
                }
            }            
        }
    }
}
