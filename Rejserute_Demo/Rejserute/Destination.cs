using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejserute
{
    internal class Destination
    {
        public static Destination destination = new();
        
        string[] destNavn = new string[4] { "Genforenings- og grænsemuseet", "Dybbøl Mølle", "Sønderborg Slot", "Sommerhuset" };
        public static int[] destAfstand = new int[7] { 0, 80, 83, 12, 4, 86, 88 };

        //Talrækken er spejlet langs diagonalen, hvor værdien = 0
        //Værdien svarer til positioner i arrayet destAfstand
        public static int[] row1 = new int[4] { 0, 1, 2, 3 };
        public static int[] row2 = new int[4] { 1, 0, 4, 5 };
        public static int[] row3 = new int[4] { 2, 4, 0, 6 };
        public static int[] row4 = new int[4] { 3, 5, 6, 0 };


        public string Name { get; set; }
        public int TotalDistance { get; set; }
        public static int[] distanceMatrix { get; set; }

        public static void CreateMatrix(Destination rowX)
        {
            for (int i = 0; i < 4; i++)
            {
                distanceMatrix[i] = destAfstand[Destination.rowX];
            }
            
        }

        int[] destStartGenforeningsOgGrænsemuseet = new int[4] { }

    }
}
