using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 4 };
            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            return (int)((A.Length == 0) ? 1 : ((long)(A.Length + 1) * (A.Length + 2) / 2) - A.Sum(x => (long)x));
        }
    }
}
