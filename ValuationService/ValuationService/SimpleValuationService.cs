using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuationService
{
    public class SimpleValuationService : IValuationService
    {
        public double CalculateInstrumentValue(string InstrumentCode, double Price, double Size, string ValuationType)
        {
            if (ValuationType == "1")
                return Price * Size;
            else return -1.00;
        }

    }
}
