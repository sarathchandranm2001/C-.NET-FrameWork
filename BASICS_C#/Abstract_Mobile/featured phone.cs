using Abstract_Mobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_mobile
{
    public class featured_phone:Mobile
    {
        public int button_count;
        public featured_phone(string brand, string model, int batteryLevel, int button_count) : base(brand, model, batteryLevel) { 
        this.button_count = button_count;
        }

        public override void StartDevice()
        {
            Console.WriteLine($"Brand: {this.brand}, Model: {this.model}, Battery Level: {this.batteryLevel}%, ButtonCount :{this.button_count}");
            throw new NotImplementedException();
        }

        public override void UseDevice()
        {
            throw new NotImplementedException();
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
        }
    }
}
