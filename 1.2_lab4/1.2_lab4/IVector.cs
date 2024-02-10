using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_lab4
{
    interface IVector//ВОТ ТУТ НАЧАЛО
    {
        double this[int i] { get; set; }
        int Length { get; }
        double GetNorm();//ВОТ ТУТ КОНЕЦ
    }
}
