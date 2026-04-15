using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUMTS
{
    internal interface IModelUltibot
    {
        int Distance { get => throw new NotImplementedException(); }

        void StartContinuousDistanceMeasurement();

        void StopContinuousDistanceMeasurement();
    }
}
