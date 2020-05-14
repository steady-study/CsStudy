using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            int data1 = 99999;
            short data2 = checked((short)data1);
            Console.WriteLine("data1 = "+data2);
        }
    }
}
