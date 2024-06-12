using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Functions
{
    internal class Android : Mobile,ICamera//inherited class
    {
        public string Version;
        public string OS;

        public Android(string brand, string model, string version, string os)
            : base(brand, model)//inherited methods
        {
            this.Version = version;
            this.OS = os;
        }
        public void Take_Photo()
        {
            Console.WriteLine("Taking a photo...");
        }

        public void Print_Android_Details()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Version: {Version}, OS: {OS}, Battery Level: {BatteryLevel}%");
        }

        public void Take_photo()
        {
            throw new NotImplementedException();
        }
    }

}
