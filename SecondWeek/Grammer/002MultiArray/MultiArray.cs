using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002MultiArray
{
    //2차원 배열 : 두개의 인덱스를 사용하는 배열. 대괄호([])와 콤마(,)로 인덱스를 구분해 선언.
    //자료형[,]
    class MultiArray
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine("array[0,0] = {0}, array[2,1] = {1}, array [1,1] = {2}", arr[0, 0], arr[2, 0], arr[1, 1]);



            int[,] Arrs = new int[2, 3];
            for(int i = 0; i<2; i++)
            {
                for(int j =0; j<3; j++)
                {
                    Arrs[i, j] = i + j;
                    Console.Write("i = {0}, ", i);
                    Console.WriteLine(" ");
                    Console.Write("j = {0}, ", j);
                    Console.WriteLine(" ");
                    Console.WriteLine("Arrs[{0}]", i + j);
                    Console.WriteLine(" ");
                }                
            }

            for(int i = 0; i<2; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.WriteLine("Arrs[{0}][{1}] = {2}", i, j, Arrs[i, j]);
                }
            }
            

        }
    }
}
