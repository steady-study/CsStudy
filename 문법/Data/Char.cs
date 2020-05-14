using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Char
    {
        static void Main(string[] args)
        {
            char c1 = '\u0061';
            char c2 = (char)97;
            char c3 = 'a';
            Console.WriteLine("'출력[1]' 문자열>>" + c1 + "\t");
            Console.WriteLine("\"출력[2]\" 문자열>>" + c2 + "\t");
            Console.WriteLine("\\출력[3]\\ 문자열>>" + c3 + "\n");

        }
    }
}
