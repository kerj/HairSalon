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

// [HttpPost("/stylist/{id}/delete")]
// public ActionResult Destroy(int id)
// {
//   Stylist.RemoveClient(id);
//   return RedirectToAction("Index");
// }
}
}

//@"SELECT name FROM client WHERE stylistId='" + id +"';";
