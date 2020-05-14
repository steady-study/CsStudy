using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014Operator03
{
    //산술 연산자 중 단항 연산자
    /* +   +A   양수부호
     * -   -A   음수부호
     * ++  ++A  전위연산자. 값 하나 증가
     * ++  A++  후위연산자. 값 하나 증가
     * --  --A  전위연산자. 값 하나 감소
     * --  A--  후위연산자. 값 하나 감소
     */
    class operator03
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("전위연산자 사용 i = " + (++i));     //10 + 1
            Console.WriteLine("후위연산자 사용 i = " + (i++));     //10 + 1    /다음 라인부터 i값 1 증가.
            Console.WriteLine("연산자 사용 후 i = " + i);    //1 + 10 + 1

            Console.WriteLine("\n전위연산자 사용 i = " + (--i));     //1 + 10 + 1 - 1
            Console.WriteLine("후위연산자 사용 i = " + (i--));     //1 + 10 + 1 - 1
            Console.WriteLine("연산자 사용 후 i = " + i);          //1 + 10 + 1 - 1 - 1
        }
    }
}
