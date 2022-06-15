using System;
using Entities;

namespace Service
{
     class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get;  private set;  }
        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
       
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duracao = carRental.End.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if ( duracao.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duracao.TotalDays);
            }
            double Tax = _taxService.Tax(basicPayment);
            carRental.InVoice = new InVoice(basicPayment, Tax); 
        }
    }
}
