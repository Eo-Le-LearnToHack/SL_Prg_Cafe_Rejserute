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
            while (true)
            {
                string myText = "Yeahhh .... Ferie .... Ruteplanlægning.";
                MovingText.YourText(myText, 1, 30); //Teksten bevæger på skærmen og samtidig skifter farve og skærmen blinker.

                Destination.CreateMatrix(); //Instantierer alle destinationer, deres afstand og ruteplan med start- og slutposition i Sommerhuset.

                for (int i = 0; i < Destination.ruteplanTotalAfstand.Length; i++) //Udskriver ruteplanerne og deres afstand
                {
                    Console.WriteLine($"Rute nr. {i + 1}: har total længde på: {Destination.ruteplanTotalAfstand[i]} km");
                    Console.WriteLine($"{Destination.ruteplanMedNavn[i]}\n");
                }

                int dots = 100;
                Console.WriteLine(MathDev.AddDots(dots));
                List<int> indexMindstAfstand = new();
                indexMindstAfstand = MathDev.GetAllIndexes(Destination.ruteplanTotalAfstand, Destination.ruteplanTotalAfstand.Min());
                if (indexMindstAfstand.Count == 1)
                {
                    Console.WriteLine($"Den rute som er kortest er:");
                    Console.WriteLine($"Rute {indexMindstAfstand[0]} ({Destination.ruteplanTotalAfstand[indexMindstAfstand[0]]} km): {Destination.ruteplanMedNavn[indexMindstAfstand[0]]}");
                }

                if (indexMindstAfstand.Count > 1)
                {
                    Console.WriteLine($"De ruter som er kortest er:");
                    foreach (int item in indexMindstAfstand)
                    { Console.WriteLine($"Rute {item + 1} ({Destination.ruteplanTotalAfstand[indexMindstAfstand[0]]} km): {Destination.ruteplanMedNavn[item]}"); }
                }
                Console.WriteLine(MathDev.AddDots(dots));


                Console.WriteLine();
                Console.WriteLine(MathDev.AddDots(dots));
                List<int> indexMaxAfstand = new();
                indexMaxAfstand = MathDev.GetAllIndexes(Destination.ruteplanTotalAfstand, Destination.ruteplanTotalAfstand.Max());
                if (indexMaxAfstand.Count == 1)
                {
                    Console.WriteLine($"Den rute som er længst er:");
                    Console.WriteLine($"Rute {indexMaxAfstand[0]} ({Destination.ruteplanTotalAfstand[indexMaxAfstand[0]]} km): {Destination.ruteplanMedNavn[indexMaxAfstand[0]]}");
                }

                if (indexMaxAfstand.Count > 1)
                {
                    Console.WriteLine($"De ruter som er længst er:");
                    foreach (int item in indexMaxAfstand)
                    { Console.WriteLine($"Rute {item + 1} ({Destination.ruteplanTotalAfstand[indexMaxAfstand[0]]} km): {Destination.ruteplanMedNavn[item]}"); }
                }
                Console.WriteLine(MathDev.AddDots(dots));
                Console.ReadLine();
                string myText1 = $"Tak hav en god dag {Environment.UserName}!!!";
                MovingText.YourText(myText1, 1, 10); //Teksten bevæger på skærmen og samtidig skifter farve og skærmen blinker.
                Console.WriteLine(myText1.ToUpper());
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Tryk på en vilkårligt tast for at køre programmet igen.");
                Console.ReadLine();
            } //EVIG LOOP
        } //PROGRAM
    } //class
} //namespace


