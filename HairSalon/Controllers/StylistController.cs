using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System;

namespace HairSalon.Controllers
{
public class StylistController : Controller
{

[HttpGet("/Stylist")]
public ActionResult Index()
{
  List<Cuisine> allStylists = Stylist.GetAll();
  return View(allStylists);
}

// [HttpGet("/cuisine/{id}")]
// public ActionResult Index(int id)
// {
//   List<Restaurant> allRestaurants = Restaurant.GetCuisineList(id);
//   return View("~/Restaurant/", allRestaurants);
// }

// [HttpPost("/cuisine/{id}/delete")]
// public ActionResult Destroy(int id)
// {
//   Cuisine.RemoveHellBeast(id);
//   return RedirectToAction("Index");
// }
}
}

//@"SELECT name FROM city WHERE cuisineId='" + id +"';";
