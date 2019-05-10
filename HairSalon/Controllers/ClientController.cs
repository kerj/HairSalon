using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System;


namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    // [HttpGet("Stylist/{id}/Client")]
    // public ActionResult Index(int id)
    // {
    //   List<Client> allClients = Client.FindStylistClientList(id);
    //   return View(allClients);
    // }

    [HttpGet("Stylist/{id}/Client")]
    public IActionResult Index(int id)
    {
      StylistBioClientViewModel AddStylistBioClientView = new StylistBioClientViewModel();
      AddStylistBioClientView.Stylist = db.GetAll();
      AddStylistBioClientView.Clients = db.FindStylistClientList(id);
      return View(AddStylistBioClientView);
    }

    [HttpGet("/Client/new")]
    public ActionResult New()
    {
      return View();
    }
    // [HttpGet("/restaurant/{id}")]
    // public ActionResult Show()
    // {
    // }

    // [HttpGet("cuisine/{id}/restaurant")]
    // public ActionResult index(int id)
    // {
    //   List<Restaurant> allRestaurants = Restaurant.GetCuisineList(id);
    //   return View(allRestaurants);
    // }

    // [HttpPost("/cuisine/{id}/delete")]
    // public ActionResult Destroy(int id)
    // {
    //   Cuisine.RemoveHellBeast(id);
    //   return RedirectToAction("Index");
    // }
  }
}
