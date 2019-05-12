using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class StylistClientListViewModel
  {
    public List<Client> Clients { get; set; }
    public int StylistId  { get; set; }
  }

}
