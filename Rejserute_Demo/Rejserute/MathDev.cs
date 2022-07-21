using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejserute
{
    internal class MathDev
    {

        public static Func<int, string> AddDots = numOfDots =>
        {
            StringBuilder sb = new();
            string dot = $".";
            for (int i = 1; i < numOfDots + 1; i++) { sb.Append(dot); }
            return sb.ToString();
        };

        public static Func<int, string> AddSpace = numOfSpaces =>
        {
            StringBuilder sb = new();
            string space = $" ";
            for (int i = 1; i < numOfSpaces + 1; i++) { sb.Append(space); }
            return sb.ToString();
        };

        public static Func<int[], int, List<int>> GetAllIndexes = (array, valueToSearchFor) =>
        {
            List<int> listResult = new();
            int counter = 0;
            var enumerator = array.GetEnumerator(); //Converting the array to an Enumerator
            while (enumerator.MoveNext()) //If value exists in enumerator then do..
            {
                if (valueToSearchFor == (int)enumerator.Current)   { listResult.Add(counter);} //Add enumerator value if exists
                counter++;
            }
            return listResult;
        };

    }// class
}// namespace


/*
        * METODER SOM IKKE ANVENDES ... 

        public static Func<int, int> Faculty = x =>
       {
           int result = 1;
           for (int i = 1; i < x + 1; i++) { result *= i; }
           return result;
       };


       public static Func<int, string> AddTab = x =>
       {
           StringBuilder sb = new();
           string tab = $"\t";
           for (int i = 1; i < x + 1; i++) { sb.Append(tab); }
           return sb.ToString();
       };


         public static Action<int[]> IndexOfRepeatingIntInArray = arr =>
       {
           ////https://stackoverflow.com/questions/16455500/how-to-get-index-of-same-elements-in-an-array
           var result =
             arr.Select((r, index) => new { Value = r, Index = index })
            .GroupBy(item => item.Value)
            .Where(grp => grp.Count() > 1)
            .Select(r => new { Indexes = r.Select(t => t.Index).ToArray() })
            .FirstOrDefault();

           foreach (var value in result.Indexes)
               Console.WriteLine(value);
       };


       public static IEnumerable<int> FindIndexes(int[] array, int value) 
       {
           //https://stackoverflow.com/questions/16455500/how-to-get-index-of-same-elements-in-an-array
           //https://www.youtube.com/watch?v=UfT-st9dl8Q
           for (int i = 0; i < array.Length; i++)
           {
               int Tempval = array[i];
               if (Tempval == value)
               {
                   yield return i;
               }
           }
       }
        */