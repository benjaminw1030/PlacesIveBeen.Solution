using Microsoft.AspNetCore.Mvc;
using PlacesIveBeen.Models;
using System.Collections.Generic;

namespace PlacesIveBeen.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string notes, string dateVisited, string travelCompanion)
    {
      Place myPlace = new Place(cityName, notes, dateVisited, travelCompanion);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

  }
}