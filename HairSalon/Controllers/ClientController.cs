using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System;


namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    [HttpGet("Stylist/{id}/Client")]
    public ActionResult Index(int id)
    {
      StylistClientListViewModel stylistClientListViewModel = new StylistClientListViewModel();
      stylistClientListViewModel.Clients =  Client.FindStylistClientList(id);
      stylistClientListViewModel.StylistId = id;
      return View(stylistClientListViewModel);
    }

    [HttpGet("/Stylist/{id}/Client/NewClient")]
    public ActionResult NewClient(int id)
    {
      Stylist clientStylist = Stylist.Find(id);
      return View(clientStylist);
    }

    [HttpPost("/Stylist/{stylistId}/Client")]
    public ActionResult Index(string name, int stylistId)
    {
      Client newClient = new Client(name, stylistId);
      newClient.Save();
      StylistClientListViewModel stylistClientListViewModel = new StylistClientListViewModel();
      stylistClientListViewModel.Clients =  Client.FindStylistClientList(stylistId);
      stylistClientListViewModel.StylistId = stylistId;
      return View(stylistClientListViewModel);
    }

    [HttpPost("/Stylist/{id}/delete")]
    public ActionResult Destroy(int id)
    {
      Stylist.DeleteStylist(id);
      return RedirectToAction("Index");
    }
  }
}
