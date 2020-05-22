using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ContinueBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while(a)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}", i);
                    
                    if(i % 2 ==0)
                    {                        
                        Console.WriteLine("{0}", i);
                        
                    }
                    continue;
                }
                break;                
            }
            
        }
    }
}
