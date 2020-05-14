using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal       
{
    //literal : 소스코드 안에서 데이터 형을 명확히 표현하기 위해 사용되는 문자.
    /* bool a = true;
     * int num1 = 100;
     * int num2 = 0x11;
     * int num3 = null;
     * float num4 = 1.2f
     * double num5 = 0.1111;
     * string str = "BlockMask"
     * 
     * true, 100, 0x11, null, 1.2f, 0.1111, "BlockMask" 모두 리터럴문자.
     */
    class literal
    {
        static void Main(string[] args)
        {
            /*
            bool a = true;          //true형 값을 갖고 있음.
            int b = 100;            //정수 100
            int c = 0x64;           //16진수는 0x를 앞에 붙임.
            int d = 0144;           //8진수는 0을 앞에 붙임.
            long e = 100L;          //long은 L을 붙임.
            float f = 100.0f;       //float은 f을 붙임.
            */

            float f = 1.0;          //컴파일러 입장에서는 1.0을 double형 자료로 판단하게 됨. 
                                    //float형 변수 f에 double형 값을 대입하려 하기때문에 오류. 
                                    //따라서 f접미사를 사용해 1.0이 float형 데이터임을 명시적으로 알수 있게 해야함.

            long a = 10L;

            Console.WriteLine("f의 값은" + f);     //오류.
            Console.WriteLine("a의 값은" + a);
        }
    }
}
