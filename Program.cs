using System;
using System.Collections.Generic;

namespace Shop
{
    abstract class Device
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }

        public abstract void PrintDeviceInfo();
    }

    class MobilePhone : Device
    {
        public string OS { get; set; }
        public int RAM { get; set; }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine("Manufacturer: {0}", Manufacturer);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Quantity: {0}", Quantity);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("OS: {0}", OS);
            Console.WriteLine("RAM: {0}", RAM);
        }
    }

    class Laptop : Device
    {
        public string CPU { get; set; }
        public int HDD { get; set; }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine("Manufacturer: {0}", Manufacturer);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Quantity: {0}", Quantity);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("CPU: {0}", CPU);
            Console.WriteLine("HDD: {0}", HDD);
        }
    }

    class Tablet : Device
    {
        public string DisplayType { get; set; }
        public int Resolution { get; set; }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine("Manufacturer: {0}", Manufacturer);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Quantity: {0}", Quantity);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Display Type: {0}", DisplayType);
            Console.WriteLine("Resolution: {0}", Resolution);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>();

            MobilePhone iPhone = new MobilePhone
            {
                Manufacturer = "Apple",
                Model = "Iphone 12 pro max",
                Quantity = 10,
                Price = 2100,
                Color = "Silver",
                OS = "iOS",
                RAM = 6
            };

            Laptop MacBook = new Laptop
            {
                Manufacturer = "Apple",
                Model = "MacBook AIR",
                Quantity = 5,
                Price = 1095.99,
                Color = "Space Gray",
                CPU = "Intel Core i7",
                HDD = 512
            };

            Tablet Xiaomi = new Tablet
            {
                Manufacturer = "Xiaomi",
                Model = "Redmi 10",
                Quantity = 7,
                Price = 300,
                Color = "Black",
                DisplayType = "IPS LCD",
                Resolution = 2560
            };

            devices.Add(iPhone);
            devices.Add(MacBook);
            devices.Add(Xiaomi);

            foreach (Device device in devices)
            {
                device.PrintDeviceInfo();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
