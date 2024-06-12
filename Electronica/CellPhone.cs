using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica
{
    internal class CellPhone : Device
    {
        public string BrandAndModel { get; set; }
        public string Screen { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string MainCamera { get; set; }
        public string FrontCamera { get; set; }
        public string Battery { get; set; }

        public CellPhone(string type, string brandAndModel, string screen, string processor, string ram, string storage, string mainCamera, string frontCamera, string battery, decimal price)
            : base(type!, price)
        {
            BrandAndModel = brandAndModel;
            Screen = screen;
            Processor = processor;
            RAM = ram;
            Storage = storage;
            MainCamera = mainCamera;
            FrontCamera = frontCamera;
            Battery = battery;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Brand and Model: {BrandAndModel}, Screen: {Screen}, Processor: {Processor}, RAM: {RAM}, Storage: {Storage}, Main Camera: {MainCamera}, Front Camera: {FrontCamera}, Battery: {Battery}");
        }
        // Implementación de IWarranty
        public override string GetWarrantyInfo()
        {
            return "2 years warranty for cell phones";
        }
    }
}
