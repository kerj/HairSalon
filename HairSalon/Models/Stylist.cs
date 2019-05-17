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
      cmd.CommandText = @"INSERT INTO `stylist` (`name`, `bio`, `specialty`) VALUES (@StylistName, @StylistBio, @StylistSpecialty);";

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
    public List<Specialty> GetSpecialties()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT specialty.* FROM stylist
      JOIN stylist_specialty ON (stylist.id =stylist_specialty.stylistId)
      JOIN items ON (stylist_specialty.specialtyId = specialty.id)
      WHERE stylist.id = @stylistId;";
      MySqlParameter stylistIdParameter = new MySqlParameter();
      stylistIdParameter.ParameterName = "@stylistId";
      stylistIdParameter.Value = Id;
      cmd.Parameters.Add(stylistIdParameter);
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      List<Specialty> Specialties = new List<Specialty>{};
      while(rdr.Read())
      {
        int specialtyId = rdr.GetInt32(0);
        string specialtyDescription = rdr.GetString(1);
        Specialty newSpecialty = new Specialty(specialtyDescription, specialtyId);
        Specialties.Add(newSpecialty);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return Specialties;
    }

    public void AddSpecial(Specialty newSpecialty)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO stylist_specialty (stylistId, specialtyId) VALUES (@stylistId, @specialtyId);";
      MySqlParameter stylistId = new MySqlParameter();
      stylistId.ParameterName = "@stylistId";
      stylistId.Value = Id;
      cmd.Parameters.Add(stylistId);
      MySqlParameter specialtyId = new MySqlParameter();
      specialtyId.ParameterName = "@specialtyId";
      specialtyId.Value = newSpecialty.Id;
      cmd.Parameters.Add(specialtyId);
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public void DeleteStylist()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = new MySqlCommand("DELETE FROM stylist WHERE id = @stylistId; DELETE FROM stylist_specialty WHERE stylistId = @stylistId;", conn);
      MySqlParameter stylistIdParameter = new MySqlParameter();
      stylistIdParameter.ParameterName = "@stylistId";
      stylistIdParameter.Value = this.Id;
      cmd.Parameters.Add(stylistIdParameter);
      cmd.ExecuteNonQuery();
      if (conn != null)
      {
        conn.Close();
      }
    }
  }
}
