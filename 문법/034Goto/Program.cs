using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034Goto
{
    //goto문은 임의의 장소로 제어를 이동시킬수 있음.
    /*  ...goto 레이블;        //레이블(Label)이란, 코드내의 위치를 나타내주는 역할을 함.
     *  
     *  ...
     *  레이블:        //레이블은 ':'으로 문장이 끝나는것 주의.
     *      //실행될 코드
     *  ...
     */
    class Program
    {
        static void Main(string[] args)
        {
            int index = 2;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    for(int k = 0; k <10; k++)
                    {
                        Console.WriteLine("{0}*{1}*{2} = {3}", i, j, k, i * j * k);
                        goto next;  //for문 더이상 돌지 않고 next로 제어(1) 이동
                    }
                }
            }
        next:  // (1)
            switch (index)
            {
                case 1:     //(2)
                    Console.WriteLine("Index =>1");     //이 문장 출력
                    goto case 3;     //case 3:으로 제어(3) 이동
                case 2: //선언해 놓은 index가 2
                    Console.WriteLine("Index => 2");    //이 문장 출력
                    goto case 1;    //case 1:로 제어(2) 이동
                case 3:     //(3)
                    Console.WriteLine("Index => 3");    //이 문장 출력
                    break;      //break으로 switch문 탈출.
            }
            Console.WriteLine("프로그램 종료");
        }
    }

    //goto문을 자주 사용하면 프로그램의 흐름이 자주 끊어져 다중 루프문에서 한번에 빠져나갈때 이외에는 가급적 사용하지 않는것을 권장.
}
