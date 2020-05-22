using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Array
{
    //배열 : 같은 종류의 데이터를 연속적으로 저장하는 자료구조. 같은 종류의 데이터들을 하나의 연속된 기억장소에 저장.
    //기본 자료형이 아닌 객체(참조 자료형)로 처리되며, new를 이용해 배열 객체를 선언하고 메모리에 값을 할당해야함.
    // 배열 선언 -> 배열에 매모리 할당(new) -> 배열요소 입,출력.
    // 선언방법:  자료형[] 배열이름;   (ex) int []a;)
    // 할당방법:  배열이름 = new 자료형[배열크기]

    class Array
    {
        
        static void Main(string[] args)
        {            
            int sum = 0;
            int[] month;        //month 배열 선언.
            month = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //배열에 값 할당.
            /*
            == int[] month = new int[12]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            == int[] month = new int{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            == int[] month = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            */

            /**********/

            int[] a = new int[100];

            for(int i = 0; i<100; i++)
            {
                a[i] = i;

                Console.WriteLine("a 배열의 개수 : {0}", a.Length);
            }

            /**********/
            int[] monthOf = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("Array.IndexOf() = {0}", System.Array.IndexOf(monthOf, 30));
            //IndexOf -> monthOf 배열 안에서 30이란 값을 찾아 제일 처음 찾은 값의 위치 반환. ∴ 3
            

            for(int i =0; i<monthOf.Length; i++)        //정석대로 monthOf의 배열 길이수 만큼 반복문 돌려서 monthOf안의 값 출력.
            {
                Console.Write("{0} , ", monthOf[i]);
            }
            Console.WriteLine(" ");

            /**********/

            Console.WriteLine("\n Array.Sort(month) --> ");
            System.Array.Sort(monthOf);        //Sort 메서드 : 1차원 배열의 요소 정렬.
            for(int i = 0; i<monthOf.Length; i++)
            {
                Console.Write("{0} , ", monthOf[i]);        //적은 수 부터 출력.
            }
            Console.WriteLine(" ");

            /**********/

            Console.WriteLine("\n Array.Reverse(monthOf) --> ");
            System.Array.Reverse(monthOf);
            for (int i = 0; i < monthOf.Length; i++)    //큰 수 부터 출력.
            {
                Console.Write("{0}, ", monthOf[i]);
            }
            Console.WriteLine("  ");

            /**********/

            String[] myArr1 = new String[5];
            myArr1.SetValue("three", 3);        //SetValue -> 값을 1차원 Array에 있는 지정한 위치의 요소로 설정. [3] 위치에 three 설정.
            Console.WriteLine("[3]: {0}", myArr1.GetValue(3));
            Console.WriteLine(" ");
        }
    }
}
