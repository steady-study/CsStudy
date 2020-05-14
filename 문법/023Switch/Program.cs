using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023Switch
{
    //switch문은 다중선택 내용을 if~else구문보다 간결하게 표현할수 있음.
    /*
     * switch(조건식)
     * {
     *     case 값1:
     *         //실행될 코드
     *         break;   //탈출
     *     case 값2:
     *         //실행될코드
     *         break;   //탈출
     * }
     */
    class Program
    {
        static void Main(string[] args)
        {
            String day = "수";

            switch (day)    //day가 참인것이 조건.
            {
                case "일":   //day값이 "일" 일때
                    Console.WriteLine("일요일입니다.");   
                    break;
                case "월":
                    Console.WriteLine("월요일입니다.");
                    break;
                case "화":
                    Console.WriteLine("화요일입니다.");
                    break;
                case "수":
                    Console.WriteLine("수요일입니다.");   //실행
                    break;
                case "목":
                    Console.WriteLine("목요일입니다.");
                    break;
                case "금":
                    Console.WriteLine("금요일입니다.");
                    break;
                case "토":
                    Console.WriteLine("토요일입니다.");
                    break;
                default:    //day값과 일치하는 case문이 없으면 실행.
                    Console.WriteLine("아무요일도 아닙니다.");
                    break;
            }
        }
    }
}
