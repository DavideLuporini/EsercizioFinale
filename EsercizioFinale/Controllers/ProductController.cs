using EsercizioFinale.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace EsercizioFinale.Controllers
{
    public class ProductController : Controller
    {
            public IActionResult Index()
            {
                using (var client = new WebClient())
                {
                    var json = client.DownloadString("https://gist.githubusercontent.com/hanse/4458506/raw/a702c19d07bd7693ee75efef18502c421b565949/phones.json");
                    var products = JsonConvert.DeserializeObject<List<Product>>(json);
                    return View(products);
                }
            }
        [HttpPost]
        public IActionResult buyProduct(string vendor , string model)
        {
            return RedirectToAction("LogOut", "Login");
        }
    }
}
