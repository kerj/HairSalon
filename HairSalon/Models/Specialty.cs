using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Specialty
  {
    public int Id {get; set;}
    public string SpecialtyDescription {get; set;}

    public Specialty (string specialtyDescription, int specialtyId = 0) {
      Id = specialtyId;
      SpecialtyDescription = specialtyDescription;
    }
  }
}
