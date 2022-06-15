using System.Globalization;

namespace Entities
{
     class InVoice
    { 
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        
        public InVoice(double basicPayment, double tax)
        {
            this.BasicPayment = basicPayment;
            this.Tax = tax;
        }
        public double TotalPayment { get { return this.BasicPayment + Tax;  } }
        public override string ToString()
        {
            return "Valor devido: R$" + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) + "\nTax: R$" + Tax.ToString("F2", CultureInfo.InvariantCulture) + "\nTotal a Pagar: R$" + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);    
        }
    }
}
