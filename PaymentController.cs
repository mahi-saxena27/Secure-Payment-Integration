using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp1.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Process(string cardNumber,string name,string expiry,string cvv)
        {
            if(string.IsNullOrEmpty(cardNumber)||string.IsNullOrEmpty(name))
            {
                ViewBag.Error = "Payment Failed:Invalid details.";
                return View("Index");  
            }
            return RedirectToAction("ThankYou", "Order");
        }
    }
}
