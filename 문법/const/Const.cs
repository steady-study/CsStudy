using System;       //자주 사용되는 값과 참조 데이터 형식, 이벤트와 이벤트 처리기, 인터페이스, 특성, 
//예외처리 등을 정의하는 기본적인 클래스 및 기본 클래스를 포함

namespace Const
{
    class Program
    {
        static void Main(string[] args)
        {
            //const [변수타입][상수이름] = 초기값;
            //상수는 선언과 동시에 반드시 초기값을 할당 해야 함.
            const int value1 = 1;
            
            const int Value2;       //선언과 동시에 초기값을 할당하지 않았기 때문에 컴파일 에러발생.
            Value2 = 2;
            
            Console.WriteLine("value1 = " + value1);
            Console.WriteLine("value2 =" + Value2);
        }
    }
}
