using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Byte
{
    class Program
    {
        static void Main(string[] args)
        {
            byte value = 254;       //byte형은 8bit를 사용해서 0~255사이의 값을 지정할 수 있음.
                                    //255는 2진수로 1111111
            Console.WriteLine("value 값은 -> {0}", value);

            value++;

            Console.WriteLine("value1 값은 -> {0}", value);

            value++;

            Console.WriteLine("value2 값은 -> {0}", value);   
            //256은 2진수로 10000000. 근데 8자리만 표현할수 있어서 00000000형태로 저장됨

            value++;

            Console.WriteLine("value3 값은 -> {0}", value);
        }
    }
}
