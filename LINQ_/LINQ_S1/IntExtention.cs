using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rout_LINQ_S1
{
    internal static class IntExtention
    {
        //Extension Method
        public static int Miror(this IComparable x)
        {
            char[] Arr = x.ToString().ToCharArray();
            Array.Reverse(Arr);

            return int.Parse(new string(Arr));
        }
    }
}
