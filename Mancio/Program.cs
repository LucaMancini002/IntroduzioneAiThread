using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Visualizzapari();
            //Visualizzadispari();
            Task.Factory.StartNew(Visualizzapari);

            Task.Factory.StartNew(Visualizzadispari);

            Console.ReadLine();
        }
        public static void Visualizzapari()
        {
            
            for (int i = 1; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
        public static void Visualizzadispari()
        {
            
            for (int i = 1; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
