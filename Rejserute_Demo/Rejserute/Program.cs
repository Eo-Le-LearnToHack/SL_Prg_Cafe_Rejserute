//Kode fakultet af 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejserute
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            //string myText = "I Like to Move it, Move it.";
            //MovingText.YourText(myText,2, 30);

            Destination.CreateMatrix();
            int counter = 0;
            for (int i = 0; i < Destination.rute.Length; i++)
            {
                
                Console.WriteLine($"Rute nr. {i+1}: har total længde på: {Destination.rute[i]}");
                Console.WriteLine($"Beregnet ud fra følgende ruteplan: ");
                if (i==0)
                {
                    foreach (string item in Destination.ruteNavnFraTil0)
                    {
                        Console.WriteLine(item);
                    }
                }
                if (i == 1)
                {
                    foreach (string item in Destination.ruteNavnFraTil1)
                    {
                        Console.WriteLine(item);
                    }
                }

            }
            Console.ReadLine();
        }
    }
}


