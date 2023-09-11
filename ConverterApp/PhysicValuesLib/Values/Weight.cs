using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    internal class Weight: AnyValue
    {
        public Weight()
        {
            ValueName = "Масса";

            CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
            { "Грамм",        0.001       },
            {"Милигармм", 0.000001},
            {"Тонна", 1000},
            {"Центнер", 100},
            {"Килограмм", 1 },
           
        };
        }
    }
}
