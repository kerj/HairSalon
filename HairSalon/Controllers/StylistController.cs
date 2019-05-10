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
      List<Stylist> allStylists = Stylist.GetAll();
      return View(allStylists);
    }

    [HttpGet("/Stylist/{id}")]
    public ActionResult Index(int id)
    {
      List<Client> allClients = Client.FindStylistClientList(id);
      return View("~/Client/", allClients);
    }

    [HttpGet("/Stylist/New")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/Stylist")]
    public ActionResult Index(string name, string bio)
    {
      Stylist newStylist = new Stylist(name, bio);
      newStylist.Save();
      List<Stylist> allStylists = Stylist.GetAll();
      return View("Index", allStylists);
    }

    // [HttpPost("/stylist/{id}/delete")]
    // public ActionResult Destroy(int id)
    // {
    //   Stylist.RemoveClient(id);
    //   return RedirectToAction("Index");
    // }
  }
}

//@"SELECT name FROM client WHERE stylistId='" + id +"';";
