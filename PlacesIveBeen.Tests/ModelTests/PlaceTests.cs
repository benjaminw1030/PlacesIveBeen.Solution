using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesIveBeen.Models;
using System;

namespace PlacesIveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Portland", "is a cool place", "9/29/2021", "Melissa");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void Getters_ReturnProperValues_String()
    {
      //Arrange
      string cityName = "Portland";
      string notes = "Is a cool place.";
      string dateVisited = "9/29/2021";
      string travelCompanion = "Ben";
      int id = 1;

      //Act
      Place newPlace = new Place(cityName, notes, dateVisited, travelCompanion);
      string result1 = newPlace.CityName;
      string result2 = newPlace.Notes;
      string result3 = newPlace.DateVisited;
      string result4 = newPlace.TravelCompanion;
      int result5 = newPlace.Id;

      //Assert
      Assert.AreEqual(cityName, result1);
      Assert.AreEqual(notes, result2);
      Assert.AreEqual(dateVisited, result3);
      Assert.AreEqual(travelCompanion, result4);
      Assert.AreEqual(id, result5);
    }

    [TestMethod]
    public void Setters_SetProperties_String()
    {
      //Arrange
      string cityName = "Portland";
      string notes = "Is a cool place.";
      string dateVisited = "9/29/2021";
      string travelCompanion = "Ben";
      Place newPlace = new Place(cityName, notes, dateVisited, travelCompanion);

      //Act
      string updatedCityName = "Seattle";
      string updatedNotes = "Really sucks.";
      string updatedDateVisited = "9/30/2021";
      string updatedTravelCompanion = "Erik";
      newPlace.CityName = updatedCityName;
      newPlace.Notes = updatedNotes;
      newPlace.DateVisited = updatedDateVisited;
      newPlace.TravelCompanion = updatedTravelCompanion;
      string result1 = newPlace.CityName;
      string result2 = newPlace.Notes;
      string result3 = newPlace.DateVisited;
      string result4 = newPlace.TravelCompanion;

      //Assert
      Assert.AreEqual(updatedCityName, result1);
      Assert.AreEqual(updatedNotes, result2);
      Assert.AreEqual(updatedDateVisited, result3);
      Assert.AreEqual(updatedTravelCompanion, result4);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      // Arrange
      List<Place> newList = new List<Place> { };

      // Act
      List<Place> result = Place.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string cityName01 = "Portland";
      string cityName02 = "Seattle";
      string notes01 = "Is cool.";
      string notes02 = "Really sucks.";
      string dateVisited01 = "9/29/2021";
      string dateVisited02 = "9/30/2021";
      string travelCompanion01 = "Melissa";
      string travelCompanion02 = "Ben";
      Place newPlace1 = new Place(cityName01, notes01, dateVisited01, travelCompanion01);
      Place newPlace2 = new Place(cityName02, notes02, dateVisited02, travelCompanion02);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      //Act
      List<Place> result = Place.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);

    }

    [TestMethod]
    public void Find_returnsCorrectPlace_Place()
    {
      //Arrange
      string cityName01 = "Portland";
      string cityName02 = "Seattle";
      string notes01 = "Is cool.";
      string notes02 = "Really sucks.";
      string dateVisited01 = "9/29/2021";
      string dateVisited02 = "9/30/2021";
      string travelCompanion01 = "Melissa";
      string travelCompanion02 = "Ben";
      Place newPlace1 = new Place(cityName01, notes01, dateVisited01, travelCompanion01);
      Place newPlace2 = new Place(cityName02, notes02, dateVisited02, travelCompanion02);

      //Act
      Place result = Place.Find(2);

      //Assert
      Assert.AreEqual(newPlace2, result);
    }
  }
}