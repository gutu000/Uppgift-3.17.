using System;
namespace Uppgift_3._17
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            string l = Console.ReadLine();
            string k = Console.ReadLine();
            int tal1 = Convert.ToInt32(l);
            int tal2 = Convert.ToInt32(k);

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string räknesätt = Console.ReadLine();
            int Svar = int.Parse(räknesätt);

             
            switch (Svar)
            {
                case 1:
                    Console.WriteLine(tal1 + tal2);
                    break;
                case 2:
                    Console.WriteLine(tal1 - tal2);
                    break;
                case 3:
                    Console.WriteLine(tal1 * tal2);
                    break;
                case 4:
                    Console.WriteLine(tal1 / tal2);
                    break;
            }
               
                  
        }
    }
}