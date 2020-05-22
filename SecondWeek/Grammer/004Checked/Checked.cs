using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 자료형이 표현할 수 있는 범위를 벗어나는 값이 입력되면 데이터 오버플로우가 발생. 오버플로우가 발생하면 최소값이 됨.
// checked연산자를 쓰면 오버플로우가 발생했다고 명시적으로 활성화 시킨다.
namespace _004Checked
{
    class Checked
    {
        
        static void Main(string[] args)
        {
            byte a = 255;
            byte b = 0;
            
            unchecked
            {
                a++;
                b--;
            }

            Console.WriteLine("컴파일 무시 a = " + a);
            Console.WriteLine("컴파일 무시 b = " + b);
            Console.WriteLine(" ");


            int x = 100000;
            int y = 5000000;
            int z = checked(x * y);

            Console.WriteLine("오버플로우 z = " + z);

            

        }
    }
}
