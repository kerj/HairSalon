using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System;

namespace HairSalon.Controllers
{
  public class SpecialtyController : Controller
  {

    [HttpGet("/Specialty")]
    public ActionResult Index()
    {
      List<Specialty> allSpecialties = Specialty.GetAll();
      return View(allSpecialties);
    }

    [HttpGet("/Specialty/NewSpecialty")]
    public ActionResult NewSpecialty()
    {
      return View();
    }

    [HttpPost("/Specialty")]
    public ActionResult Index(string specialtyDescription)
    {
      Specialty newSpecialty = new Specialty(specialtyDescription);
      newSpecialty.Save();
      List<Specialty> allSpecialties = Specialty.GetAll();
      return View("Index", allSpecialties);
    }

    [HttpGet("/Specialty/{stylistId}")]
    public ActionResult Show()
    {
      StylistClientListViewModel stylistClientListViewModel = new StylistClientListViewModel();
      List<Specialty> allSpecialties = Specialty.GetAll();
      return View();
    }
  }
}
