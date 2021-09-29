using System.Collections.Generic;

namespace PlacesIveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Notes { get; set; }
    public string DateVisited { get; set; }
    public string TravelCompanion { get; set; }
    public string Image { get; set; }
    public int Id { get; }
    private static List<Place> _places = new List<Place> {};

    public Place(string cityName, string notes, string dateVisited, string travelCompanion, string image)
    {
      CityName = cityName;
      Notes = notes;
      DateVisited = dateVisited;
      TravelCompanion = travelCompanion;
      Image = image;
      _places.Add(this);
      Id = _places.Count;
    }

    public static List<Place> GetAll()
    {
      return _places;
    }

    public static void ClearAll()
    {
      _places.Clear();
    }

    public static Place Find(int searchId)
    {
      return _places[searchId-1];
    }
  }
}