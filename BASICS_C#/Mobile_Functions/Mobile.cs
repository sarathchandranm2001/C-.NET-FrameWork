using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Functions
{
    internal class Mobile
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int BatteryLevel { get; set; }

        public Mobile(string brand, string model)
        {
            Brand = brand;
            Model = model;
            BatteryLevel = 75; // Initial battery level set to 75%
        }

        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Making a call to {phoneNumber}...");
        }

        public void ChargeBattery(int charge)
        {
            BatteryLevel = charge;
            Console.WriteLine($"Battery charged to {BatteryLevel}%");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Battery Level: {BatteryLevel}%");
        }
    }
}
