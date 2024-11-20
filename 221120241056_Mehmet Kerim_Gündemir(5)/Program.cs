using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221120241056_Mehmet_Kerim_Gündemir_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int icaci1;
            Console.WriteLine("Birinci açıyı giriniz");
            icaci1 = Convert.ToInt16(Console.ReadLine());
            int icaci2;
            Console.WriteLine("İkinci açıyı giriniz");
            icaci2 = Convert.ToInt16(Console.ReadLine());   
            int icaci3;
            Console.WriteLine("Üçüncü açıyı giriniz");
            icaci3 = Convert.ToInt16(Console.ReadLine());

            if (icaci1 + icaci2 + icaci3 < 180)
            {
                Console.WriteLine("Bu bir üçgen değil");

            }
            else if (icaci1 + icaci2 + icaci3 > 180)
            {
                Console.WriteLine("Bu bir üçgen değil");
            }
            else if (icaci1 + icaci2 + icaci3 == 180)
            {
                Console.WriteLine("Bu bir üçgen");
            }
            Console.Read();
           



            

            
            
            

        }
    }
}
