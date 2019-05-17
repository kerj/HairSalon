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
      return View();
    }

    [HttpGet("/Stylist/NewStylist")]
    public ActionResult NewStylist()
    {
      return View();
    }

    [HttpPost("/Stylist")]
    public ActionResult Index(string name, string bio, string specialty)
    {
      Stylist newStylist = new Stylist(name, bio, specialty);
      newStylist.Save();
      List<Stylist> allStylists = Stylist.GetAll();
      return View("Index", allStylists);
    }

    [HttpGet("/Stylist/{id}/show")]
    public ActionResult Show(int id)
    {

      List<Stylist> allStylists = Stylist.GetAll();
      Stylist selectedStylist = Stylist.Find(id);
      return View(selectedStylist);
    }



    [HttpPost("/stylist/{id}/delete")]
    public ActionResult Delete(int id)
    {
      Stylist selectedStylist = Stylist.Find(id);
      selectedStylist.DeleteStylist();
      return RedirectToAction("Index");
    }
  }
}

//@"SELECT name FROM client WHERE stylistId='" + id +"';";
