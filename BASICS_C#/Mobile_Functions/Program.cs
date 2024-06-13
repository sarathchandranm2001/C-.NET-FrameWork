using System;

namespace Mobile_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Android myPhone = new Android("Samsung", "Galaxy S21", "11.0");

            
            myPhone.Brand = "Samsung";
            myPhone.Model = "Galaxy S21";
            myPhone.OSVersion = "11.0";

            
            myPhone.ChargeBattery(75);

            
            myPhone.MakeCall("123-456-7890");

            
            myPhone.TakePhoto();

            
            myPhone.GetLocation();

            myPhone.PrintAndroidDetails();
        }
    }
}
