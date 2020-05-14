using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020Convert
{
    //  Convert클래스 이용해서 기본 자료형(byte, short, int, char, float, double)간의 형 변환 처리 가능.
    /*
     * Convert 클래스가 제공하는 변환 메서드 종류
     * ToByte, ToDouble, ToInt16, ToInt32, ToInt64, ToString 등등 
     */
    class Convertt
    {
        static void Main(string[] args)
        {
            string data1 = "1234567";   //문자열형식의 data1. 정수1234567아님.
            float data2 = 10.5f;        //flaot형식의 data2
            int data3 = 0;              //int형 data3 초기화.

            Console.WriteLine("문자열 data1= " + data1);   //"1234567" 출력.

            data3 = Convert.ToInt32(data1) + Convert.ToInt32(data2);
                    //1234567 + 10(double형이랑 float형을 int로 변환시키면 소수점 떨어짐.)
            Console.WriteLine("계산값 = " +data3);     //1234577
        }
    }
}
