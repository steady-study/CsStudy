using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027For02
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1,j=10; (i<10)&&(j>=1); i++, j--)
                //초기값, 조건식, 증감식에 ,를 이용해 추가 가능.
            {
                Console.WriteLine("{0},{1}", i, j);
            }
        }
    }
}
