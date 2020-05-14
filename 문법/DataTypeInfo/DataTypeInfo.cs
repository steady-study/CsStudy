using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeInfo
{
    class DataTypeInfo
    {
        static void Main(string[] args)
        {
            int data1 = 1;
            float data2 = 10.5f;
            Console.WriteLine("data1과 data2는 {0}", data1.Equals(data2));    // false
            //같은 객체인지 비교. bool타입 반환
            Console.WriteLine("data1 타입 : {0}", data1.GetType());           //System.Int32
            //객체의 형 반환
            Console.WriteLine("data2 타입 : {0}", data2.GetType());           //System.Single

            Console.WriteLine("data2의 문자열 : {0}", data2.ToString());      //10.5 -> 숫자를 문자 형태로 출력
            //객체의 이름을 문자열로 반환

            Console.WriteLine("data2의 해시코드 : {0}", data2.GetHashCode());    //1093140480
            //hashcode : 동등성 테스트 중에 객체를 식별하는데 사용되는 숫자 값. 고유값.
            //객체의 해시코드 반환

            Console.WriteLine("data1의 BaseType:{0}", data1.GetType().BaseType); //System.ValueType
            //직접 상속된 형식을 가져옴
            //int형 변수의 기본형이 System.ValueType에 있음.

            Console.WriteLine("문자열의 BaseType:{0}", "문자열".GetType().BaseType); //System.Object
            //문자열은 기본형이 System.Object
        }
    }
}
