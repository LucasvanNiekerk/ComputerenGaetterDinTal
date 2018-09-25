using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ComputerenGætterDinTal
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberToGuess = 0;
            Console.ForegroundColor = ConsoleColor.Red; //swag
            Console.WriteLine("Velkommen til sort magi, hvor ved hjælp af blek megi (aka computeren) vil vi nu gætte dit tal!");
            Console.WriteLine("Tænk venligst på et heltal mellem 0 og 31.\n");

            Console.WriteLine("16\t17\t18\t19\n20\t21\t22\t23\n24\t25\t26\t27\n28\t29\t30\t31");
            Console.WriteLine("\nEr dit tal på denne plade? ja/nej");
            Console.WriteLine("Stavefejl antages til at være et nej");
            String svar = Console.ReadLine();
            if (svar.ToLower() == "ja") //fordi Resul er en idiot
            {
                Console.Clear();
                NumberToGuess = NumberToGuess + 16;
                Console.WriteLine("8\t9\t10\t11\n12\t13\t14\t15\n24\t25\t26\t27\n28\t29\t30\t31");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("8\t9\t10\t11\n12\t13\t14\t15\n24\t25\t26\t27\n28\t29\t30\t31");
            }

            Console.WriteLine("\nEr dit tal på denne plade? ja/nej");
            svar = Console.ReadLine();
            if (svar.ToLower() == "ja")
            {
                Console.Clear();
                NumberToGuess = NumberToGuess + 8;
                Console.WriteLine("4\t5\t6\t7\n12\t13\t14\t15\n20\t21\t22\t23\n28\t29\t30\t31");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("4\t5\t6\t7\n12\t13\t14\t15\n20\t21\t22\t23\n28\t29\t30\t31");
            }

            Console.WriteLine("\nEr dit tal på denne plade? ja/nej");
            svar = Console.ReadLine();
            if (svar.ToLower() == "ja")
            {
                Console.Clear();
                NumberToGuess = NumberToGuess + 4;
                Console.WriteLine("2\t3\t6\t7\n10\t11\t14\t15\n18\t19\t22\t23\n26\t27\t30\t31");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("2\t3\t6\t7\n10\t11\t14\t15\n18\t19\t22\t23\n26\t27\t30\t31");
            }

            Console.WriteLine("\nEr dit tal på denne plade? ja/nej");
            svar = Console.ReadLine();
            if (svar.ToLower() == "ja")
            {
                Console.Clear();
                NumberToGuess = NumberToGuess + 2;
                Console.WriteLine("1\t3\t5\t7\n9\t11\t13\t15\n17\t19\t21\t23\n25\t27\t29\t31");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("1\t3\t5\t7\n9\t11\t13\t15\n17\t19\t21\t23\n25\t27\t29\t31");
            }

            Console.WriteLine("\nEr dit tal på denne plade? ja/nej");
            svar = Console.ReadLine();
            if (svar.ToLower() == "ja")
            {
                NumberToGuess = NumberToGuess + 1;
                Console.WriteLine(NumberToGuess);
            }
            else
            {
                Console.WriteLine(NumberToGuess);
            }
        }
    }
}
