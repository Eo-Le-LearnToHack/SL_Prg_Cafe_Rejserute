using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejserute
{
    internal class Destination
    {
        public static Destination[] destination = new Destination[4];
        
        public static string[] destNavn = new string[4] { "Genforenings- og grænsemuseet", "Dybbøl Mølle", "Sønderborg Slot", "Sommerhuset" };
        public static int[] destAfstand = new int[7] { 0, 80, 83, 12, 4, 86, 88 };

        //Talrækken er spejlet langs diagonalen, hvor værdien = 0
        //Værdien svarer til positioner i arrayet destAfstand
        public static int[] row0 = new int[4] { 0, 1, 2, 3 };
        public static int[] row1 = new int[4] { 1, 0, 4, 5 };
        public static int[] row2 = new int[4] { 2, 4, 0, 6 };
        public static int[] row3 = new int[4] { 3, 5, 6, 0 };


        public string Name { get; set; }
        public int TotalDistance { get; set; }
        public  int distanceZero { get; set; }
        public  int distanceOne { get; set; }
        public  int distanceTwo { get; set; }
        public  int distanceThree { get; set; }
        public int[] distanceMatrix = new int[4];

        public int[,] travelMatrix0 = new int[4,2] { 
            { 3, 0 }, 
            { 0, 1 }, 
            { 1, 2 }, 
            { 2, 3} };

        public int[,] travelMatrix1 = new int[4, 2] {
            { 3, 0 },
            { 0, 2 },
            { 2, 1 },
            { 1, 3} };

        public int[,] travelMatrix2 = new int[4, 2] {
            { 3, 1 },
            { 1, 0 },
            { 0, 2 },
            { 2, 3} };

        public int[,] travelMatrix2 = new int[4, 2] {
            { 3, 1 },
            { 1, 0 },
            { 0, 2 },
            { 2, 3} };

        public static void CalcTravelDistance0(Destination destination)
        {
            int travelOption0 = destination.distanceMatrix[3] //start i 3
        }
       
        public static void CreateMatrix()
        {
            CreateMatrix0();
            CreateMatrix1();
            //CreateMatrix2();
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
                    if (i == 0)
                    {
                        destination[i].distanceMatrix[j] = destAfstand[row0[j]];
                    }
                    if (i == 1)
                    {
                        destination[i].distanceMatrix[j] = destAfstand[row1[j]];
                    }
                    if (i == 2)
                    {
                        destination[i].distanceMatrix[j] = destAfstand[row2[j]];
                    }
                    if (i == 3)
                    {
                        destination[i].distanceMatrix[j] = destAfstand[row3[j]];
                    }
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



    }
}
