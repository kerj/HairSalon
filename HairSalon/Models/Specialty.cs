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

    public override bool Equals(System.Object otherSpecialty)
    {
      if (!(otherSpecialty is Specialty))
      {
        return false;
      }
      else
      {
        Specialty newSpecialty = (Specialty) otherSpecialty;
        bool idEquality = (this.Id == newSpecialty.Id);
        bool specialtyEquality = (this.SpecialtyDescription == newSpecialty.SpecialtyDescription);
        return (idEquality && specialtyEquality);
      }
    }

    public static List<Specialty> GetAll()
    {
      List<Specialty> allSpecialties = new List<Specialty> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM specialty;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        int id = rdr.GetInt32(0);
        string specialtyDescription = rdr.GetString(1);

        Specialty newSpecialty = new Specialty(specialtyDescription, id);
        allSpecialties.Add(newSpecialty);
      }
      conn.Close();

      if (conn != null)
      {
        conn.Dispose();
      }
      return allSpecialties;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO `specialty` (`specialtyDescription`) VALUES (@specialtyDescription);";

      MySqlParameter specialtyDescription = new MySqlParameter();
      specialtyDescription.ParameterName = "@specialtyDescription";
      specialtyDescription.Value = this.SpecialtyDescription;

      cmd.Parameters.Add(specialtyDescription);
      cmd.ExecuteNonQuery();
      Id = (int) cmd.LastInsertedId; // <-- This line is new!
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static List<Specialty> FindStylistSpecialtyList(int id)
    {
      List<Specialty> stylistSpecialties = new List<Specialty> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand getStylistSpecialtyList = conn.CreateCommand() as MySqlCommand;
      getStylistSpecialtyList.CommandText =
       @"SELECT *
        FROM stylist
        JOIN stylist_specialty
          ON (stylist.Id = stylist_specialty.stylistId)
        JOIN specialty
          ON (stylist_specialty.specialtyId = specialty.Id)
        WHERE stylist.Id ='" + id +"';";
      MySqlDataReader rdr = getStylistSpecialtyList.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        int specialtyId = rdr.GetInt32(0);
        string specialtyDescription = rdr.GetString(1);

        Specialty newSpecialty = new Specialty(specialtyDescription, specialtyId);
        stylistSpecialties.Add(newSpecialty);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return stylistSpecialties;
    }

  }
}
