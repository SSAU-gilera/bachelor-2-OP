using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab5
{
    public interface IVector
    {
        double this[int i]
        {
            get;
            set;
        }
        int Length
        {
            get;
            set;
        }
        double GetNorm();
    }
}
