using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab6
{
    interface IVector : IComparable, ICloneable
    {
        Int32 Length { get; }
        double GetNorm();
        double this[int ndx] { get; set; }
    }
}
