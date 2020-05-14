using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLiteral
{
    //키워드 자체를 식별자로 사용해야 하는 경우에 키워드 앞에 @를 붙이면 됨.
    //이때 @를 문자열 리터럴이라고 부름.
    class KeyLiteral
    {
        static void Main(string[] args)
        {
            int @int = 20;
            Console.WriteLine("int값 = " + @int);    //실행결과 -> int값 = 20
        }
    }
}
