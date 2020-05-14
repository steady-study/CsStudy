using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031Break02
{
    class Program
    {
        //반지름이 1부터 10까지의 원의 면적 합이 1000보다 작은 수 찾기.
        static void Main(string[] args)
        {
            double Sircle = 0;  //원의 면적
            double sum = 0;     //면적의 합.
            
            for(int i = 1; i < 10; i++)
            {
                Sircle = i * i * Math.PI;   //반지름x반지름xPI = 원의 면적.
                sum += Sircle;
                Console.WriteLine("{0}", sum);                

                if (Sircle > 1000)                                   
                    break;
                
            }

            Console.WriteLine("원의 넓이가 1000보다 적은 수 = {0}", sum);
        }
    }
}
