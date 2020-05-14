using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012Operators
{
    //연산자에는 단항 연산자, 이항(binary) 연산자, 삼항 연산자 있음.
    class binaryOperator
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 7;
            
            //산술연산자 중 이항(binary) 연산자
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("A * B = " + (A * B));
            Console.WriteLine("A / B = " + (A / B));    //나누기
            Console.WriteLine("A % B = " + (A % B));    //나머지
        }
    }
}
