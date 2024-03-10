using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace EnrollmentSystem.Controllers
{
    public class HelperController : Controller
    {
        public IActionResult CallForm(string path)
        {
            return PartialView(path);
        }
    }
}
