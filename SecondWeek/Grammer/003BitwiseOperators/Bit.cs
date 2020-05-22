using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//비트 연산자는 char, byte, short, int, long 자료형에 사용 가능. char형을 제외하고 맨 왼쪽 비트가 부호 비트. 0이면 양수, 1이면 음수.
/*      10진수        2진수         16진수
 *        1         0000 0001       0x01
 *        0         0000 0000       0x00
 *       -1         1111 1111       0xFF
 */

namespace _003BitwiseOperators
{
    class Bit
    {
        static void Main(string[] args)
        {
            //시프트 연산자 : >>,<< 이 연산자는 정수를 지정한 비트만큼 왼쪽 또는 오른쪽으로 이동시킴.
            /* 
             A<<B -> 정수 A를 B비트만큼 왼쪽으로 이동시킴. 오른쪽 비트는 항상 0으로 채움. 계산결과) A*2의B승과 같은 결과. ex) 1 << 2 => 4
             A>>B -> 정수 A를 B비트만큼 오른쪽으로 이동시키고, 왼쪽비트는 양수일 경우 0으로, 음수일 경우 1로 채움. 계산결과) A/2의B승과 같은 결과 ex) 2<<1 =>  1              
             */

            int x = 1;
            int y = -1;
            Console.WriteLine("시프트 연산 x = 1 , y = -1");
            Console.WriteLine("x << 1 = {0}", x << 1);
            Console.WriteLine("y << 1 = {0}", y << 1);
            Console.WriteLine("x >> 1 = {0}", x >> 1);
            Console.WriteLine("y >> 1 = {0}", y >> 1);
            Console.WriteLine(" ");



            //비트 연산자. &,|,^,! 연산자.
            /*
            & : AND 연산자. 항상 A와 B값이 참(1)일 경우에 참을 반환.
            | : OR 연산자. A와 B 값이 모두 거짓(0)일 경우만 거짓이고 나머지일 경우 항상 참/ A나 B 중 한개만 참(1)이면 참 반환.
            ^ : XOR 연산자. A와 B 값이 같으면 항상 거짓(0) 반환.
            ~ : NOT 연산자. 참일경우에는 거짓, 거짓일 경우에는 참 반환.
            */
            bool a = true;
            bool b = false;
            if (a | b)
            {
                Console.WriteLine("a | b = {0}", a | b);
            }
            

            if(a & b)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("a & b = {0}", a & b);
            }


            if (a ^ b)
            {
                Console.WriteLine("a ^ b = {0}", a ^ b);
            }
           

            if(a != b)
            {
                Console.WriteLine("(a != b) = {0}", a !=b);
            }
            Console.WriteLine(" ");
        }
    }
}
