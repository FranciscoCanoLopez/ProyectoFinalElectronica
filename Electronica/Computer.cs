using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica
{
    internal class Computer : Device 
    {
        public string BrandAndModel { get; set; }
        public string Screen { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string Graphics { get; set; }
        public string OperatingSystem { get; set; }

        public Computer(string type, string brandAndModel, string screen, string processor, string ram, string storage, string graphics, string operatingSystem, decimal price)
            : base(type, price)
        {
            BrandAndModel = brandAndModel;
            Screen = screen;
            Processor = processor;
            RAM = ram;
            Storage = storage;
            Graphics = graphics;
            OperatingSystem = operatingSystem;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Brand and Model: {BrandAndModel}, Screen: {Screen}, Processor: {Processor}, RAM: {RAM}, Storage: {Storage}, Graphics: {Graphics}, Operating System: {OperatingSystem}");
        }
        // Implementación de IWarranty
        public override string GetWarrantyInfo()
        {
            return "3 years warranty for computers";
        }
    }
}
