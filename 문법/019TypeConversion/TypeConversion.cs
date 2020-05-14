using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019TypeConversion
{
    /*
    형변환 : 데이텨형의 표현 범위를 늘려주는 확대변환/반대인 경우인 축소변환이 있음.
    확대 변환은 안전하며 컴파일러가 묵시적으로 변환해 주기 때문에 에러가 발생하지 않음.
    하지만 축소 변환을 할 경우에는 반드시 새로운 데이트형 명시에 주어야 함.
    확대변환은 암시적 형식 변환이라 부르고, 축소변환은 명시적 형식 변환이라 부름.
    */
    // (새로운 데이터형) 변수

    class TypeConversion
    {
        static void Main(string[] args)
        {
            byte A;
            int B = 365;
            double C = 1024.512;
            Console.WriteLine("축소형 변환 결과");

            A = (byte)B;
            Console.WriteLine("int형 365를 byte형으로 바꾸면: " + A);   //109
            //365를 2진수로 표현하면 101101101. byte는 8비트를 사용하는데 맨 앞 1비트는 부호표현용도.
            //따라서 1101101만 남아서 이 값을 10진수로 환산하면 109가 나옴.

            B = (int)C;
            Console.WriteLine("double형 1024.512를 int형으로 바꾸면: " + B);//1024
            //double형 변수를 int형으로 변환하면 소수점만 사라짐.

            A = (byte)C;
            Console.WriteLine("double형 1024.512를 byte형으로 바꾸면" + A);

        }
    }
}
