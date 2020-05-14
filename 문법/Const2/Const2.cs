using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const2
{
    class Const2
    {
        static void Main(string[] args)
        {
            const int VALUE = 1;
            Console.WriteLine("[1] VALUE = " + VALUE);
            VALUE = 2; //상수는 한번 선언하면 도중에 그 값을 바꿀수 없다. 라는 규칙 때문에 컴파일 에러 발생.
            Console.WriteLine("[2] VALUE = " + VALUE);
        }
    }
}
