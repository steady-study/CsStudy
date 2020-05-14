using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022If
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 85;

            if (grade > 90)
                Console.WriteLine("성적은 A");     //조건식이 참일 경우 실행될 문장
            else if (grade > 80)    //else if는 if문에 종속된 문장. 
                Console.WriteLine("성적은 B");
            else if (grade > 70)
                Console.WriteLine("성적은 C");
            else if (grade > 60)
                Console.WriteLine("성적은 D");
            else
                Console.WriteLine("성적은 F");     //위의 조건식에 아무것도 해당되지 않을때 실행될 문장
            
        }

        
    }
}
