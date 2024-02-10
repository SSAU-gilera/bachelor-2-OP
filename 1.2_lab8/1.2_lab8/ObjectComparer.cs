using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab8
{
    public class ObjectComparer : IComparer
    {
        public int Compare(object a, object b)
        {
            return (a is Employee _a && b is Employee _b) ? _a.Name.CompareTo(_b.Name) : throw new NotSupportedException();
        }
    }
}
