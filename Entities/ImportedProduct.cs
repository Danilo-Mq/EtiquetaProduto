using System.Globalization;

namespace /*Insira aqui o nome do seu namespace*/.Entities
{
    class ImportedProduct : Product
    {

        public Double CustomsFee { get; set; }
        public ImportedProduct(){}
        
        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public Double totalPrice()
        {
            return CustomsFee + Price;
        }

        public override string ToString()
        {
            return Name
                + " $ "
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + "(Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
