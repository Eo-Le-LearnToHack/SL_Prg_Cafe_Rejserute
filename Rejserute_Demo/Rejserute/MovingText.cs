using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejserute
{
    internal class MovingText
    {
        public static int counter = 0;

        public static void YourText(string textDisplay, int cycle, int distanceTravel)
        {
            StringBuilder sb = new();

            for (int i = 0; i < textDisplay.Length; i++)
            {
                Console.Clear();
                sb.Append(textDisplay.Substring(i, 1));
                Console.Write(sb);
                Thread.Sleep(30); //Sleep 30ms
            }

            while (MovingText.counter < cycle)
            {
                for (int i = 0; i < cycle; i++)
                {
                    for (int j = 0; j < distanceTravel; j++)
                    {
                        Console.Clear();
                        if (j % 2 == 0) { Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Black; }
                        else if (j % 2 == 1) { Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Yellow;}
                            Console.WriteLine(MathDev.AddSpace(j) + textDisplay.ToUpper());
                        Thread.Sleep(50); //Sleep 50ms
                    }

                    for (int j = distanceTravel; j > -1; j--)
                    {
                        Console.Clear();
                        if (j % 2 == 0) { Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Black; }
                        else if (j % 2 == 1) { Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Yellow; }
                        Console.WriteLine(MathDev.AddSpace(j) + textDisplay.ToUpper());
                        Thread.Sleep(50); //Sleep 50ms
                    }
                    MovingText.counter++;
                }
            }//while (MovingText.counter < cycle)
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            counter = 0;
        }//public static void YourText(string textDisplay, int cycle, int distanceTravel)



    }//class
}//namespace
