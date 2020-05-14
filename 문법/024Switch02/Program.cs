using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024Switch02
{
    class Program
    {
        //중첩switch문.
        static void Main(string[] args)
        {
            int count = 3;
            int age = 25;
            switch (count)
            {
                case 1:
                    break;
                case 3: //count = 3일때
                    switch (age)    //age값 검사.
                    {
                        case 20:
                        case 25:    //age가 20이거나 25이면 
                            Console.WriteLine(count + "를 선택하고 나이는 20대");    //실행
                            break;  //탈출.
                        case 30:    
                        case 35:    //age가 30이거나 35이면
                            Console.WriteLine(count + "를 선택하고 나이는 30대");    //실행
                            break;  //탈출
                    }
                    break;  //case 3:의 break. break 안쓰면 오류뜸.
                default:    //switch(count)의 default.
                    break;
            }
        }
    }
}
