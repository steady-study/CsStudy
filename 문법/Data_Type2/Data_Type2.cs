using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type2
{
    /*
     * float 범위:±1.5 X 10-45 ~ ±3.4 X 1038 /크기:32bit /초기값:0.0F
     * double 범위:±5.0 X 10-324 ~ ±1.7 X 10308 /크기:64bit /초기값:0.0D
     * decimal 범위:7.9E-28 ~ 7.9E+28(28자리 유효) /크기:128bit /초기값 : 0.0M
     */
    class Data_Type2
    {
        static void Main(string[] args)
        {
            float f = 1.1f;
            double d = 1.1;
            Console.WriteLine(f);
            Console.WriteLine(d);
        }
    }
}
