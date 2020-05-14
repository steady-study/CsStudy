using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type1
{
    class Data_Type1
    {
        static void Main(string[] args)
        {
            byte b = 10;        //10진수
            short s = 010;      //8진수 앞에 0을 붙임
            int i = 0x10;       //16진수 앞에 0x를 붙임.
            long l = 10;        //10진수

            Console.WriteLine("byte : " + b);
            Console.WriteLine("short : " + s);
            Console.WriteLine("int : " + i);
            Console.WriteLine("long : " +l);
        }
    }
}
