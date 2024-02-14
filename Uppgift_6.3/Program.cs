using System;
namespace Uppgift_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            while (svar != "3")
            {
                Console.WriteLine("1: addera 3 tal");
                Console.WriteLine("2: största talet av 2 tal");
                Console.WriteLine("3: avsluta programmet");

                svar = Console.ReadLine();
                switch (svar)
                {
                    case "1":
                        MenyvalAddera();
                        break;

                    case "2":
                        MenyvalStörstaTalet();
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine("Ogiltigt alternativ");
                        break;
                }

                Console.WriteLine();
            }           
        }
        /// <summary>
        /// Läser in ett int-tal från användaren
        /// </summary>
        /// <returns>Talet användaren skrev</returns>
        static int ReadInt()
        {
            int tal;
            while (!int.TryParse(Console.ReadLine(), out tal))
            {
                Console.WriteLine("Ogiltigt svar. Försök igen");
            }
            return tal;
        }
        /// <summary>
        /// Adderar 3 tal
        /// </summary>
        /// <param name="tal1">Tal 1</param>
        /// <param name="tal2">Tal 2</param>
        /// <param name="tal3">Tal 3</param>
        /// <returns>Summan av talen</returns>
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
        /// <summary>
        /// Returnerar det största av 2 tal
        /// </summary>
        /// <param name="tal1">Tal 1</param>
        /// <param name="tal2">Tal 2</param>
        /// <returns>Det största av talen</returns>
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }
        static void MenyvalAddera()
        {
            Console.WriteLine("Skriv in de 3 tal du vill addera på varsin rad");
            int tal1 = ReadInt();
            int tal2 = ReadInt();
            int tal3 = ReadInt();
            Console.WriteLine("Summan av talen är " + Addera(tal1,tal2,tal3));
        }
        static void MenyvalStörstaTalet()
        {
            Console.WriteLine("Skriv in 2 tal för att veta vilket som är störst");
            int tal1 = ReadInt();
            int tal2 = ReadInt();
            Console.WriteLine("Det största talet av dem är " + Störst(tal1,tal2));
        }
    }
}