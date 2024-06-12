using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica
{
    internal class Device : Iwarrenty
    {
        // Propiedades
        public string Category { get; }//lectura
        public decimal Price { get; set; }//lectura y escritura

        //constructores

        public Device(string category, decimal price)
        {
            Category = category;
            Price = price;
        }
        //metodo publico
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Category: {Category}, Price: {Price}");
        }

        public virtual string GetWarrantyInfo()
        {
            return "Default warranty information";
        }
    }
}
