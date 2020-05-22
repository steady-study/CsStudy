using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 접근 지정자
     * private : 클래스 내부에서만 접근 가능
     * public : 모든 곳(파생 클래스 포함)에서 해당 멤버로 접근 가능.
     * protected : 클래스 외부에선 접근 불가. 파생 클래스에서는 접근 가능
     * internal : 같은 어셈블리(.NET 프레임 워크 응용 프로그램을 구성하는 기본 컴포넌트) 내에 있는 다른 타입들이 엑세스 할수 있음 //  헌재 프로젝트 안에서는 가능
     */
namespace _007AccessModifier
{
    class Math              //class 앞에 제한자 생략하면 보통 internal 생략.
    {
        public int a;
        private int b;
        protected int c;
        internal int d;

        public int x;
        int y;             //멤버 앞에 제한자 생략하면 보통 private생략.
    }

    class Plus : Math
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Plus plus = new Plus();
            OutClass o = new OutClass();

            math.a = 1;
            //math.b = 2;       //보호수준때문에 에러. private는 동일 클래스나 구조체에서만 접근 가능.
            math.d = 9;
            plus.c = 7;

            math.x = math.d + plus.c;

            Console.WriteLine("a + c = {0}", math.a + plus.c);
            Console.WriteLine("d + c = " + math.x);

            o.month1 = "January";
            //o.month2 = "Apil";          //private
            //o.month3 = "March";         //protected 
            o.month4 = "May";           //internal은 동일 어셈블리 내에서 접근 가능.

            Console.WriteLine("1월 = {0}, 5월 = {1}", o.month1, o.month4);
        }       
    }

    

}
