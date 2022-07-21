using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejserute
{
    public class Destination
    {
        public static Destination[] destination = new Destination[4];
        public string Name { get; set; }
        
        public static string[] destNavn = new string[4] { "Genforenings- og grænsemuseet", "Dybbøl Mølle", "Sønderborg Slot", "Sommerhuset" };
        public static int[] destAfstand = new int[7] { 0, 80, 83, 12, 4, 86, 88 };

        //Talrækken er spejlet langs diagonalen, hvor værdien = 0
        //Værdien svarer til positioner i arrayet destAfstand
        public static int[] row0 = new int[4] { 0, 1, 2, 3 };
        public static int[] row1 = new int[4] { 1, 0, 4, 5 };
        public static int[] row2 = new int[4] { 2, 4, 0, 6 };
        public static int[] row3 = new int[4] { 3, 5, 6, 0 };
        public int[] distanceMatrix = new int[4];

        public static int[] ruteplanTotalAfstand = new int[6];
        public static string[] ruteplanMedNavn = new string[6];

        public static void CreateMatrix()
        {
            CreateMatrix0(); //Instantiate 4x destination objects
            CreateMatrix1(); //Tildeling destinationsobjekterne navn og afstand som defineret i opgavenstabel https://studie.smartlearning.dk/mod/page/view.php?id=603712
            //CreateMatrix2(); //ANVENDES IKKE..Udskriver objekternes navn og deres afstand
            CreateMatrix3(); //Genererer ruteplanen og total rejselængde.
        }


        public static int CalcTravelDistance(Destination[] destination, int startPosition, int first, int second, int third)
        {
            int travelOption0 = destination[startPosition].distanceMatrix[first]; 
            int travelOption1 = destination[first].distanceMatrix[second]; 
            int travelOption2 = destination[second].distanceMatrix[third]; 
            int travelOption3 = destination[third].distanceMatrix[startPosition];
            int travelTotal = travelOption0 + travelOption1 + travelOption2 + travelOption3;

            return travelTotal;
        }

        public static String CalcTravelRouteName(Destination[] destination, int startPosition, int first, int second, int third)
        {
            string travelOption0 = destination[startPosition].Name; 
            string travelOption1 = destination[first].Name; ; 
            string travelOption2 = destination[second].Name; ; 
            string travelOption3 = destination[third].Name; ;

            return $"{travelOption0} ==> {travelOption1} ==> {travelOption2} ==> {travelOption3} ==> {travelOption0}";
        }


        public static Destination[] CreateMatrix0()
        {
            for (int i = 0; i < 4; i++) { destination[i] = new Destination(); }
            return destination;
        }

        public static void CreateMatrix1()
        {
            for (int i = 0; i < 4; i++)
            {
                destination[i].Name = destNavn[i];
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0) {destination[i].distanceMatrix[j] = destAfstand[row0[j]];}
                    if (i == 1) {destination[i].distanceMatrix[j] = destAfstand[row1[j]];}
                    if (i == 2) {destination[i].distanceMatrix[j] = destAfstand[row2[j]];}
                    if (i == 3) {destination[i].distanceMatrix[j] = destAfstand[row3[j]];}
                }
            }
        }

        public static void CreateMatrix2()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(Destination.destination[i].Name + " " + Destination.destination[i].distanceMatrix[j]);
                }
            }
        }

        public static void CreateMatrix3()
        {
            ruteplanTotalAfstand[0] = CalcTravelDistance(destination, 3, 0, 1, 2);
            ruteplanTotalAfstand[1] = CalcTravelDistance(destination, 3, 0, 2, 1);
            ruteplanTotalAfstand[2] = CalcTravelDistance(destination, 3, 1, 0, 2);
            ruteplanTotalAfstand[3] = CalcTravelDistance(destination, 3, 1, 2, 0);
            ruteplanTotalAfstand[4] = CalcTravelDistance(destination, 3, 2, 1, 0);
            ruteplanTotalAfstand[5] = CalcTravelDistance(destination, 3, 2, 0, 1);

            ruteplanMedNavn[0] = CalcTravelRouteName(destination, 3, 0, 1, 2);
            ruteplanMedNavn[1] = CalcTravelRouteName(destination, 3, 0, 2, 1);
            ruteplanMedNavn[2] = CalcTravelRouteName(destination, 3, 1, 0, 2);
            ruteplanMedNavn[3] = CalcTravelRouteName(destination, 3, 1, 2, 0);
            ruteplanMedNavn[4] = CalcTravelRouteName(destination, 3, 2, 1, 0);
            ruteplanMedNavn[5] = CalcTravelRouteName(destination, 3, 2, 0, 1);
        }


    }
}
