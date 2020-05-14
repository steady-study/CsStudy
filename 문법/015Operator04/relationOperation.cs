using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015Operator04
{
    class Program
    {
        //관계 연산자, False나 True값 반환.
        /*  A > B       A가 B보다 크면 True
         *  A >= B      A가 B보다 크거나 같으면 True
         *  A < B       A가 B보다 작으면 True
         *  A <= B      A가 B보다 작거나 같으면 True
         *  A == B      A와 B가 같으면 True
         *  A != B      A와 B가 같지 않으면 True
         */
        static void Main(string[] args)
        {
            bool A = (3 > 10);
            bool B = (10 > 4);

            Console.WriteLine("A=" + A + " B=" + B);
        }
    }
}
