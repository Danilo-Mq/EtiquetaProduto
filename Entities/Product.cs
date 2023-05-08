using System;
using System.Collections.Generic;
using System.Globalization;

namespace /*Insira aqui o nome do seu namespace*/.Entities
{
    class Product
    {

        public String Name { get; set; }
        public Double Price { get; set; }
        
        public Product(){}

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
