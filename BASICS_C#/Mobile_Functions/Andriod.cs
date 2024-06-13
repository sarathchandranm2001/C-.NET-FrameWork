using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Functions
{
    internal class Android : Mobile, ICamera, IGPS
    {
        public string OSVersion { get; set; }

        public Android(string brand, string model, string osVersion)
            : base(brand, model)
        {
            OSVersion = osVersion;
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking a photo...");
        }

        public void GetLocation()
        {
            Console.WriteLine("Getting the current location...");
        }

        public void PrintAndroidDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, OS Version: {OSVersion}, Battery Level: {BatteryLevel}%");
        }
    }
}

