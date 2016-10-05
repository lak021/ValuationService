using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuationService
{
    interface IValuationService
    {
        double CalculateInstrumentValue(string InstrumentCode, double Price, double Size, string ValuationType);
    }
}
