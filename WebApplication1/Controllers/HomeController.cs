using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
          new Product{Name="Huawei",Id=1,Price=3000,Description="Telefon novu",Image="https://www.mytrendyphone.eu/images/Huawei-P40-Lite-5G-128GB-Silver-6901443396986-07082020-01-p.jpg"},
          new Product{Name="Samsung",Id=2,Price=3000,Description="Telefon novu",Image="http://cdn.shopify.com/s/files/1/0611/4633/3396/products/61YVqHdFRxL._AC_SL1322.jpg?v=1637559706"},
          new Product{Name="Iphone",Id=3,Price=3000,Description="Telefon novu",Image="https://images.frandroid.com/wp-content/uploads/2021/09/p1022463-scaled.jpg"}
            };

            return View();
        }
    }
}
