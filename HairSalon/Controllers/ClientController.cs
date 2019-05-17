using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System;


namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    [HttpGet("/Client")]
    public ActionResult ClientIndex()
    {
      List<Client> viewClients = Client.GetAll();
      return View(viewClients);
    }

    [HttpGet("/Client/New")]
    public ActionResult New()
    {
      List<Client> viewClients = Client.GetAll();
      return View(viewClients);
    }

    [HttpPost("/Client")]
    public ActionResult ClientIndex(string name, int stylistId = 0)
    {
      Client newClient = new Client(name, stylistId);
      newClient.Save();
      List<Client> viewClients = Client.GetAll();
      return View(viewClients);
    }

    [HttpGet("Stylist/{id}/Client")]
    public ActionResult Index(int id)
    {
      StylistClientListViewModel stylistClientListViewModel = new StylistClientListViewModel();
      stylistClientListViewModel.Clients =  Client.FindStylistClientList(id);
      Stylist selectedStylist = Stylist.Find(id);
      stylistClientListViewModel.SelectedStylist = selectedStylist;
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
      stylistClientListViewModel.SelectedStylist = Stylist.Find(stylistId);
      return View(stylistClientListViewModel);
    }

    [HttpGet("/client/{clientId}/edit")]
    public ActionResult Edit(int clientId, int stylistId = 0)
    {
      StylistClientListViewModel stylistClientListViewModel = new StylistClientListViewModel();
      stylistClientListViewModel.Clients =  Client.FindStylistClientList(clientId);
      stylistClientListViewModel.SelectedStylist = Stylist.Find(stylistId);

      return View(stylistClientListViewModel);
    }

    [HttpPost("/client")]
    public ActionResult Update(int stylsitId, int clientId, string name)
    {
      Client client = Client.Find(clientId);
      client.Edit(name);

      return RedirectToAction("Show", clientId);
    }


  }
}
