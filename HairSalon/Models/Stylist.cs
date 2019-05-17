using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int Id {get; set;}
    public string Name {get; set;}
    public string Bio {get; set;}
    public string Specialty {get; set;}

    public Stylist (string name, string bio, string specialty, int id = 0) {
      Id = id;
      Name = name;
      Bio = bio;
      Specialty = specialty;
    }

    public static List<Stylist> GetAll()
    {
      List<Stylist> allStylists = new List<Stylist> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM stylist;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        int id = rdr.GetInt32(0);
        string name = rdr.GetString(1);
        string bio = rdr.GetString(2);
        string specialty = rdr.GetString(3);

        Stylist newStylist = new Stylist(name, bio, specialty, id);
        allStylists.Add(newStylist);
      }
      conn.Close();

      if (conn != null)
      {
        conn.Dispose();
      }
      return allStylists;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM stylist";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static void DeleteStylist(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM `stylist` WHERE id = @thisId;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public override bool Equals(System.Object otherStylist)
    {
      if (!(otherStylist is Stylist))
      {
        return false;
      }
      else
      {
        Stylist newStylist = (Stylist) otherStylist;
        bool idEquality = (this.Id == newStylist.Id);
        bool nameEquality = (this.Name == newStylist.Name);
        bool bioEquality = (this.Bio == newStylist.Bio);
        bool specialtyEquality = (this.Specialty == newStylist.Specialty);
        return (idEquality && nameEquality && bioEquality && specialtyEquality);
      }
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO `stylist` (`name`, `bio`) VALUES (@StylistName, @StylistBio);";

      MySqlParameter name = new MySqlParameter();
      name.ParameterName = "@StylistName";
      name.Value = this.Name;

      MySqlParameter bio = new MySqlParameter();
      bio.ParameterName = "@StylistBio";
      bio.Value = this.Bio;

      MySqlParameter specialty = new MySqlParameter();
      specialty.ParameterName = "@StylistSpecialty";
      specialty.Value = this.Specialty;

      cmd.Parameters.Add(name);
      cmd.Parameters.Add(bio);
      cmd.Parameters.Add(specialty);
      cmd.ExecuteNonQuery();
      Id = (int) cmd.LastInsertedId;
      // more logic will go here in a moment
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static Stylist Find(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM `stylist` WHERE id = @thisId;";
      MySqlParameter thisId = new MySqlParameter();
      thisId.ParameterName = "@thisId";
      thisId.Value = id;
      cmd.Parameters.Add(thisId);
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      string stylistName = "";
      string stylistBio = "";
      int stylistId = 0;
      string stylistSpecialty = "";

      while (rdr.Read())
      {
        stylistId = rdr.GetInt32(0);
        stylistName = rdr.GetString(1);
        stylistBio = rdr.GetString(2);
        stylistSpecialty = rdr.GetString(3);
      }

      Stylist foundStylist = new Stylist(stylistName, stylistBio, stylistSpecialty, stylistId);
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return foundStylist;
    }
  }
}
