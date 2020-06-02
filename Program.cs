using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AntiPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int Numb = num.Next(1, 11);
            int[] prime = new int[] { 2, 3, 5, 7 };
            
            string HopefullyNotAPrime = Numb.ToString();
            Console.WriteLine("Your number is:{0}", HopefullyNotAPrime);
            Console.ReadKey();
            if(Numb==2)
            {
                //this.Close()
            }
            if (Numb == 3)
            {
                
            }
            if (Numb == 5)
            {
               
            }
            if (Numb == 7)
            {
                
            }
        }
    }
}
