using Microsoft.AspNetCore.Mvc;

namespace EsercizioFinale.Models
{
    public class Product
    {
        public string Vendor { get; set; }
        public string Model { get; set; }

        public Product(string vendor, string model)
        {
            Vendor = vendor;
            Model = model;
        }
    }
}
