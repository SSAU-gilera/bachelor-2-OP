using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab5
{
    class SortByNorm : IComparer<IVector>
    {
        public int Compare(IVector vector1, IVector vector2)
        {
            if (vector1.GetNorm() > vector2.GetNorm())
            {
                return 1;
            }
            else
            {
                if (vector1.GetNorm() < vector2.GetNorm())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
