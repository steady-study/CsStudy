using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Method
{
    //메서드(Method)는 C#에서 특정 작업을 처리하는 최소한의 덩어리. 메서드 매개변수(parameter)로 특정값을 입력하면 내부 연산을 통해 특정 값 반환.
    /*  기본 형태.
    [접근 지정자][반환값 타입] 메서드 이름([매개변수])
    {
         코드
         return 반환 값;
    }        
    */
    
    
    class Method
    {
        static void Main(string[] args)     //static : 정적 메서드를 선언할때 이용하는 키워드.
        {

            Console.WriteLine("{0}\n", Division(30, 10));       //메소드 오버로딩 함수 이름은 같고 매개변수만 다르게 함으로써 함수를 여러개 만듦.
            Console.WriteLine("{0}\n", Division(40.5, 10.0));
            Console.WriteLine("{0}\n", Division(40, 5, 2));

            /*****/

            int x, y;
            x = 5;
            y = 10;
            Console.WriteLine("Main1(x,y)값 = ({0}, {1})", x, y);
            Swap(x, y);

            Console.WriteLine("CallByValue -> (x,y)값 = ({0}, {1})", x, y);
            Console.WriteLine(" ");

            Swap1(ref x, ref y);        //ref 키워드는 변수의 메모리 주소를 전달.
            Console.WriteLine("CallByReference -> (ref x, ref y)값 = ({0}, {1})", x, y);
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }
        
        public static double Division(double a, double b)
        {
            return a / b;
        }
        public static int Division(int a, int b, int c)
        {
            return a / b / c;
        }


        /*****/
        public static void Swap(int x, int y)       //메서드에 매개변수 전달하는 방법1. 값에 의한 호출
        {
            int temp = x;
            x = y;
            y = temp;
            //값이 바뀌긴 하지만, 원본과 메서드 안에 있는 값이 서로 다른 메모리 공간에 할당되기 때문에 main문에서는 x,y값 그대로 유지.
            Console.WriteLine("Swap(x, y)값 = ({0}, {1})", x, y);
        }

        public static void Swap1(ref int x, ref int y)      //메서드에 매개변수 전달하는 방법2. 참조에 의한 호출
        {
            int temp = x;
            x = y;
            y = temp;
            //인수로 전달한 변수와 호출된 메서드에서 사용하는 변수가 서로 같은 메모리 공간 사용. 그래서 main문 에서도 x,y값 바뀜
            Console.WriteLine("Swap1(x, y)값 = ({0}, {1})", x, y);
        }
    }
}
