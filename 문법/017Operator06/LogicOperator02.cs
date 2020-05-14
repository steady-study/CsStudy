using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017Operator06
{
    //논리 연산자
    /* &&  AND연산자.  항상 A와 B의 값이 참(1)인 경우에 참(1).
     * ||  OR 연산자.  A,B 어느 하나라도 참(1)인 경우에 참(1).
     * ^   XOR 연산자. A와 B가 모두 참이거나 거짓일 경우(A==B)에는 항상 거짓(0)이고, A와 B가 다를 경우(A !=B)에는 항상 참(1)
     *  !  NOT 연산자. 참일 경우엔 거짓, 거짓일 경우에는 참
     */
    class LogicOperator02
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;

            Console.WriteLine("a = true, b = true");

            if (a && b) //true && true 이므로 true되서 if문 안으로 들어감.
            {
                Console.WriteLine("a && b 는 참");    //출력
            }

            if (a || b) //ture || ture -> true 이므로
            {
                Console.WriteLine("a || b 참");      //출력.
            }

            Console.WriteLine(" ");

            a = false;
            b = true;
            Console.WriteLine("a = fasle, b = true");
            if (a && b) //true && fasle -> false
            {
                Console.WriteLine("a && b는 거짓");   //출력 안됨.
            }
            else if(a || b) //true || false -> true
            {
                Console.WriteLine("a || b는 참");     //출력
            }
            else if(a ^ b)  //ture ^ true -> false
            {
                Console.WriteLine("a ^ b는 거짓");     //출력 안됨.
            }
            
        }
    }
}
