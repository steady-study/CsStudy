using System;

namespace Data_Bool
{
    class Bool
    {
        static void Main(string[] args)
        {
            bool bn = true;         //System.Boolean타입. 이 변수는 오직 true/false값만 표현 할 수 있음.

            if (bn)
                Console.WriteLine("select => True");
            else
                Console.WriteLine("select => False");
        }
    }
}
