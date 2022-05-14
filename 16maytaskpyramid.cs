using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid(6, 6);
        
        }


        static void Pyramid(int en,int hundurluk)
        {
            
            

                for (int i = 0; i < en; i++)
                {
                    for (int j = 0; j < hundurluk; j++)
                    {
                        if (i < j)
                        {

                            break;
                        }
                        Console.Write('*');

                    }
                    Console.WriteLine(' ');

                }

           
           

        }
    
    
    
    
    
    
    
   
    
    }
}
