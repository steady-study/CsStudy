using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031Break
{
    class Program
    {
        //0~100사이의 숫자중 3의 배수의 합이 200보다 작은수 찾기.
        static void Main(string[] args)
        {            
            int sum = 0;
            int j = 0;
            for(int i = 0; i <= 100; i++) //i를 0부터 100까지 한개씩 증가하면서 반복
            {
                if(i%3 == 0)    //i를 3으로 값의 나머지가 0이면(3의 배수이면)
                {
                    sum += i;   //sum = sum + i
                    Console.Write("{0}\t", i);
                    
                    if (sum > 200) //sum이 200보다 작으면 다시 돌아가서 for문으로.
                    {
                        Console.WriteLine("");
                        Console.WriteLine("{0} 더하면 200보다 큼",i);
                        j = sum - i;
                        break;
                    }
                    //break;
                    //break문의 주된 용법은 가장 가까운 블록의 끝 '}'으로 제어를 이동시킴.
                }
                //break문은 반복문(for, while, do~while)의 루프를 탈출하거나 선택문(if, switch)에서 사용.
            }   //제어가 이곳으로 이동.
                        
            Console.WriteLine("");
            Console.WriteLine("3의 배수 중, 200보다 작은수 = {0}",j);           
            
        }
    }
}
