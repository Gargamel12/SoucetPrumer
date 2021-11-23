
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
            int rowNumber = 0;
            do
            {
                keyInfo = Console.ReadKey(true); //Zachycení stisknuté klávesy
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    //když uživatel zmáčkne Enter
                    Console.WriteLine();
                    Console.WriteLine(text);
                    rowNumber++; 
                    text = "";
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && text.Length > 0) 

                {
                    //Když uživatel zmáčkne backspace
                    //přepíšu řádek mezerma, počet podle délky textu
                    Console.SetCursorPosition(0, rowNumber);
                    Console.Write(new string(' ',text.Length));
                    
                    //zkrátím text
                    
                    text = text.Substring(0,text.Length-1);
                    //napíšu zkrácený text
                    Console.SetCursorPosition(0, rowNumber);
                    Console.Write(text);

                }
                else if (LeCisla.Contains(keyInfo.KeyChar))
                {
                    //Když uživatel napsal číslici
                    text = text + keyInfo.KeyChar;
                    Console.SetCursorPosition(0,rowNumber);
                    Console.Write(text);
                }
            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
