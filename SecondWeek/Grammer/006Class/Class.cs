using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Class
{
    class Class       //1.
    {
        private int _data;      //필드, 멤버변수

        public int data     //puboic [데이터 타입][속성이름]
        {
            get { return _data; }       //값 가져올때. /_data값 읽어오기.
            set { _data = value; }      //Value 키워드를 이용해 값 지정./ _data값 지정.
        }
    }

    class Indexer
    {
        private int size;
        public string[] strArray;
        public string this[int index]       //this 키워드 이용해 인덱서 정의. int 파라미터 사용.
        /*
          인덱서 : 내부 컬렉션, 배열을 캡슐화 하는데 주로 사용되는 형식에서 자주 구현. 
          get/set키워드 사용해서 인덱서 데이터를 읽거나 쓸수 있고 인덱서는 인스턴수 변수를 마치 배열처럼 사용할수 있다.
         */
        {
            get     //return되는 값 받아옴.
            {
                if(index > -1 && index < size)
                {
                    return strArray[index];
                }
                else
                {
                    Console.WriteLine("인덱스값 오류");
                    return null;                        
                }
            }
            set 
            {
                try
                {
                    strArray[index] = value;
                }
                catch
                {
                    Console.WriteLine("예외발생");
                }
                
            }
        }

        public int Lenth
        {
            get { return strArray.Length; }
        }

        public Indexer(int strSize)     //생성자. 클래스명과 동일한 메서드 명. 
        //객체를 생성하기 위해 존재하고 객체를 생성할때 객체의 멤버변수를 원하는 값으로 초기화 하고 싶을때 주요 사용 
        {
            size = strSize;         //strSize == 3
            Console.WriteLine("{0}", size);
            strArray = new string[size];
            Console.WriteLine("{0}", strArray);
        }
    }

    class ClassExam
    {
        static void Main(string[] args)
        {          
            //2.
            Class program = new Class();    //클래스 선언방법 -> 클래스명 객체참조변수 = new 클래스생성자명();  /
            //  객체참조변수(개체인스턴스) /클래스 초기화와 관련된 기능을 처리하는 클래스 생성자명.
            // 어떤 클래스가 존재하기만 한다면 그 클래스의 객체를 어디서나 만들수 있음.

            for (int i = 0; i < 5; i++)
            {
                program.data = i;               //program에 객체에 대한 메모리가 실제로 할당되어, 멤버변수인 data에 접근할수 있게 됨.
                int a = program.data;   

                Console.WriteLine("\n{0}", a);
            }


            /*******/


            Indexer obj = new Indexer(3);       //3. new Indexer()안의 인수가 strSize에 해당. 
            obj[0] = "안녕하세요";
            obj[1] = "인덱스 예제";
            obj[2] = "인덱스는 스마트 배열로 불림";
            obj[3] = "오류";
            obj[4] = "배열 범위 벗어남";


            for (int i = 0; i < obj.Lenth; i++)
                Console.WriteLine("[{0}] = {1}", i, obj[i]);
        }
    }
}
