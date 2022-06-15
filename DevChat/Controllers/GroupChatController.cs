using Microsoft.AspNetCore.Mvc;

namespace DevChat.Controllers
{
    public class GroupChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
