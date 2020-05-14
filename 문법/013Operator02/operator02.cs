using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013Operator02
{
    class operator02
    {
        //산술 연산을 처리할 때 주의사항
        //byte(1byte), char(2byte), short(2byte)와 같이 int(4byte)보다 작은 크기의 데이터 형은 무조건 int로 변환되어 계산됨.

        static void Main(string[] args)
        {
            byte A = 10;
            short B = 10;
            short C = 0;
            /*
            C = A + B;
            C = A * B;
            */

            byte a = 5;
            short b = 9;
            int c = 0;

            c = a + b;
            //c = a * b;

            //Console.WriteLine("{0}", C);
            Console.WriteLine("{0}", c);
        }
    }
}
