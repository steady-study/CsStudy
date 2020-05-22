using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace _002Equal
{
    //equal 메서드와 == 연산자 비교 
    /*
     * .NET Framework에서 데이터 유형은 특정 타입 변수가 자체 데이터를 저장하는지 또는 데이터에 대한 포인터를 저장하는지 분류될 수 있는데,
     * 변수가 자체 데이터를 저장하는 경우 Value Type 이고 메모리의 다른 위치에 있는 데이터에 대한 포인터를 보유하는 경우 Reference Type.
     * 객체 데이터 유형의 변수에 참조 타입 또는 값 타입을 지정 가능
     * 
     * equal 메서드 -> 두 개체 인스턴스가 같은지 확인.   -> value equality로 값이 같음.
     * == 연산자 -> 피 연산자가 같은지 여부 확인.   -> reference equality(also known as identity)로 참조된 값이 같음.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string a = "11";            
            string b = "1111".Substring(0, 2);
            string c = b;
            Console.WriteLine("Equals = " + a.Equals(b) + "\t" + a.Equals(c));

            Console.WriteLine("(==) = " + (a == b) + "\t" + (a == c));
            Console.WriteLine("");


            string i = "34";
            string j = "1234".Substring(2, 2);
            string k = j;
            Console.WriteLine(Equals(i, j) + "\t" +Equals(i, k));
            Console.WriteLine((i == j) + "\t" + (i == k));


            object x = 33;
            object y = "33";
            object z = x;

            Console.WriteLine(" x.Equls(z) = {0}", x.Equals(z));
            Console.WriteLine(" (x == z) = {0}", x == z);


            



        }        
    }
}
