using Microsoft.AspNetCore.Mvc;

namespace PlacesIveBeen.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}