using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Functions
{
    interface ICamera
    {
        void TakePhoto();
    }

    interface IGPS
    {
        void GetLocation();
    }
}

