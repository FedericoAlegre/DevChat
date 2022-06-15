using Microsoft.AspNetCore.Mvc;

namespace DevChat.Controllers
{
    public class PrivateMessagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
