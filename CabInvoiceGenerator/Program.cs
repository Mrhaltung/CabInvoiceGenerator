using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator \n ");
            InvoiceGenertor invoiceGenerator = new InvoiceGenertor(RideType.Normal);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");

            Ride[] rides = { new Ride(2.0, 5), new Ride(1.0, 1) };
            invoiceGenerator.AddRides("Dipesh", rides);

            invoiceGenerator.GetInvoiceSummary("Dipesh"); 
        }
    }
}