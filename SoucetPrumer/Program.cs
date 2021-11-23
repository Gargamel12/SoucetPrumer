
using System;

namespace SoucetPrumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            string LeCisla = "0123456789";
            string text = "";
            do
            {
                keyInfo = Console.ReadKey(true); //Zachycení stisknuté klávesy
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    //když uživatel zmáčkne Enter
                    Console.WriteLine();
                    Console.WriteLine(text);
                    text = "";
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    //Když uživatel zmáčkne backspace
                    text = text.Substring(0,text.Length-1);
                    Console.SetCursorPosition(0, 0);
                    Console.Write(text);
                }
                else if (LeCisla.Contains(keyInfo.KeyChar))
                {
                    //Když uživatel napsal číslici
                    text = text + keyInfo.KeyChar;
                    Console.SetCursorPosition(0,0);
                    Console.Write(text);
                }
            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
