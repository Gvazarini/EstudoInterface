using System.Globalization;
using Entities;
using Service;
namespace ServiceCarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque os dados do aluguel abaixo. ");
            Console.Write("Entre com o modelo do carro: ");
            string modelocarro = Console.ReadLine();
            Console.Write("Data de retirada (dd/MM/YYYY HH:mm): ");
            DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de devolução (dd/MM/YYYY HH:mm) : ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por hora: R$");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por dia: R$");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Invoice: ");
            CarRental carRental = new CarRental(retirada, devolucao, new Vehicle(modelocarro));
            RentalService rentalService = new RentalService(precoHora, precoDia, new BrazilTaxSerice());
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine(carRental.InVoice);
        }
    }
}
