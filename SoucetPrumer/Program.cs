
using System;

namespace SoucetPrumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(false); //Zachycení stisknuté klávesy
                if (keyInfo.Key == ConsoleKey.Enter) 
                { 
                    //když uživatel zmáčkne Enter
                }
                else if (keyInfo.Key == ConsoleKey.Backspace) 
                {

                }
                Console.WriteLine(keyInfo.KeyChar);
            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
