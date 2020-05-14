using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016Operator05
{
    class LogicOperator01
    {
        /* 논리 연산자 : 두개의 논리 변수를 평가하여 결과를 true 또는 false로 반환/ 조건과 조건을 비교.
         *  &&,&  '그리고' (조건식A) && (조건식B)    -> A가 참이고 B도 참이면 참.
         *  ||,|  '또는'   (조건식A) || (조건식B)    -> A 또는 B가 참이면 참.
         *   !  '~가 아니다'  !(조건식A)             -> 'A가 참'이면 거짓.
         */

        static void Main(string[] args)
        {
            bool A = (3 > 10) & (10 > 3);       //두 항 모두 확인
            bool B = (3 > 10) && (10 > 3);      //첫번째 항이 거짓이면 두번째 항 확인 안하고 그냥 false반환
            bool C = (10 > 3) | (3 > 10);       //두 항 모두 확인
            bool D = (10 > 3) || (3 > 10);      //첫번째 항이 참이면 True반환.

            Console.WriteLine("A=" + A + " B=" + B + " C=" + C + " D=" + D);
        }
    }
}
