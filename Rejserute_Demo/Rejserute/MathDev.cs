using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejserute
{
    internal class MathDev
    {
        public static Func<int, int> Faculty = x =>
        {
            int result = 1;
            for (int i = 1; i < x + 1; i++) { result *= i; }
            return result;
        };

        public static Func<int, string> Tab = x =>
        {
            StringBuilder sb = new();
            string tab = $"\t";
            for (int i = 1; i < x + 1; i++) { sb.Append(tab); }
            return sb.ToString();
        };

        public static Func<int, string> Space = x =>
        {
            StringBuilder sb = new();
            string space = $" ";
            for (int i = 1; i < x + 1; i++) { sb.Append(space); }
            return sb.ToString();
        };

    }
}
