using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUMTS
{
    internal interface IView
    {
        event EventHandler ButtonStartUltrasonic_Click
        {
            add => throw new NotImplementedException();
            remove => throw new NotImplementedException();
        }

        void DisplayDistance(int newDistance);

        void SwitchButtonStartUltrasonic(bool isActive);
    }
}
