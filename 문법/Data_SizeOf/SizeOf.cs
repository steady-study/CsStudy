using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_SizeOf
{
    class SizeOf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bool 자료형 크기 : {0}byte", + sizeof(bool));        
            //4byte
            Console.WriteLine("char 자료형 크기 : {0}byte", sizeof(char));
            //U+0000 ~ U+ffff    2byte
            Console.WriteLine("sbyte 자료형 크기 : {0}byte", sizeof(sbyte));
            //-128 ~ 127         1byte
            Console.WriteLine("byte 자료형 크기 : {0}byte", sizeof(byte));
            //0~255              1byte
            Console.WriteLine("short 자료형 크기 : {0}byte", sizeof(short));
            //-32,768 ~ 32,767   2byte
            Console.WriteLine("ushort 자료형 크기 : {0}byte", sizeof(ushort));
            //0 ~ 65,535         2byte
            Console.WriteLine("int 자료형 크기 : {0}byte", sizeof(int));
            //-2147483648 ~ 2147483647          4byte
            Console.WriteLine("uint 자료형 크기 : {0}byte", sizeof(uint));
            //0 ~ 4,294,967,295                 4byte
            Console.WriteLine("long 자료형 크기 : {0}byte", sizeof(long));
            //
            Console.WriteLine("ulong 자료형 크기 : {0}byte", sizeof(ulong));

            Console.WriteLine("float 자료형 크기 : {0}byte", sizeof(float));
            //± 1.5 X 10 - 45 ~ ± 3.4 X 1038       4byte
            Console.WriteLine("double 자료형 크기 : {0}byte", sizeof(double));
            //± 5.0 X 10 - 324 ~ ± 1.7 X 10308     8byte
            Console.WriteLine("decimal 자료형 크기 : {0}byte", sizeof(decimal));
            //7.9E-28 ~ 7.9E+28                     16byte
        }
    }
}
