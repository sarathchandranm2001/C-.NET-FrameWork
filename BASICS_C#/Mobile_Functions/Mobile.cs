using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Functions
{
    internal class Mobile
    {
        public string Brand;
        public string Model;
        public int BatteryLevel;

        public Mobile(String Brand,String Model) {
            this.Brand = Brand;
            this.Model = Model;
            this.BatteryLevel = 75;
        
        }//initiate initial values for atrrtibutes

        public void Make_Call(string phoneNumber)
        {
            Console.WriteLine(phoneNumber);
            
        }

        public void Charge_Battery(int charge)
        {
            if (BatteryLevel == 0)
            {
                Console.WriteLine("No Battery ! Charge Your Mobile");
            }
            else if (BatteryLevel <= 10)
            {
                Console.WriteLine("Battery Level low !!! Charge Your Mobile");
            }
            else if (BatteryLevel == 100)
            {
                Console.WriteLine("Fully Charged");
            }
            else
            {
                Console.WriteLine($"Battery level {BatteryLevel}");
            }
        }

        public void Use_Model()
        {
        }

        public void Print_Details()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Battery Level: {BatteryLevel}%");
        }
        
      }
}
