using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparator
{
    public class CustomComparator : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 == 0)
            {
                return x.CompareTo(y);
            }
            else if (x % 2 == 0)
            {
                return -1;
            }
            else if (y % 2 == 0)
            {
                return 1;
            }
            else
            {
                return x.CompareTo(y);
            }
        }
    }
}
