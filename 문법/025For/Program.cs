using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025For
{
    //for문  반복횟수가 정해진 문장에서 주로 사용. 참이될때까지 반복
    /*
     * for(초기값; 종료조건; 증감치)
     * {
     *     반복 문장;
     * }
     */
    class Program
    {
        static void Main(string[] args)
        {            
            for (int i =0; i<11; i++)   //i초기값 설정, i가 10일때 종료 i는 하나씩 증가
            {
                //초기식 -> 조건식 -> 코드실행 -> 증감식 -> 조건식 -> 코드실행 -> 증감식 -> ...
                Console.Write(i + "\t");
            }
        }
    }
}
