using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult MyProfilePage()
        {
            return View("~/Views/ProfilePage/MyProfilePage.cshtml");
        }
        public IActionResult OrderHistoryPage()
        {
            return View("~/Views/ProfilePage/OrderHistoryPage.cshtml");
        }
    }
}
