
using System;

namespace SoucetPrumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            string LeCisla = "0123456789";
            do
            {
                keyInfo = Console.ReadKey(true); //Zachycení stisknuté klávesy
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    //když uživatel zmáčkne Enter
                    Console.WriteLine();
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    //Když uživatel zmáčkne backspace

                }
                else if (LeCisla.Contains(keyInfo.KeyChar))
                {
                    //Když uživatel napsal číslici
                    Console.Write(keyInfo.KeyChar);
                }
            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
