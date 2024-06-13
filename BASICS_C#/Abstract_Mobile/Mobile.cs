using System;

namespace Abstract_Mobile
{
    public abstract class Mobile
    {
        protected string brand;
        protected string model;
        protected int batteryLevel;

        public Mobile(string brand, string model, int batteryLevel)
        {
            this.brand = brand;
            this.model = model;
            this.batteryLevel = batteryLevel;
        }

        public abstract void StartDevice();
        public abstract void UseDevice();

        public abstract void ShowDetails();

    }
}
