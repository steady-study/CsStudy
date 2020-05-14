using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028Foreach
{
    //foreach문 : 배열, 컬렉션(데이터모음/ArrayList이나 스택,큐 등등)등을 반복하는데 주로 사용
    // 순회하며 차례대로 접근.
    /*
     * foreach(변수 in 배열 혹은 컬렉션)
     * {
     *     //실행될 코드.
     * }
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr={ 1, 2, 3, 5, 8, 9, 11, 17, 20 };
                        
            foreach(int i in arr)   //배열에 담겨있는 각각의 데이터를 순회하면서 변수 i에 집어넣음
            {
                Console.WriteLine("i: {0}",i);  //차례대로 i출력.
            }            
        }
    }
}
