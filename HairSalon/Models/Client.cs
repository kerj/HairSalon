using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    public int Id {get; set;}
    public int StylistId {get; set;}
    public string Name {get; set;}

    public Client (string name, int stylistId, int id = 0) {
      Name = name;
      StylistId = stylistId;
      Id = id;
    }

    public static List<Client> GetAll()
    {
      List<Client> allClients = new List<Client> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM client;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        int id = rdr.GetInt32(0);
        int stylistId = rdr.GetInt32(1);
        string name = rdr.GetString(2);

        Client newClient = new Client(name, stylistId, id);
        allClients.Add(newClient);
      }
      conn.Close();

      if (conn != null)
      {
        conn.Dispose();
      }
      return allClients;
    }

    public static List<Client> FindStylistClientList(int id)
    {
      List<Client> stylistClients = new List<Client> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand getStylistClientList = conn.CreateCommand() as MySqlCommand;
      getStylistClientList.CommandText = @"SELECT * FROM client WHERE stylistId='" + id +"';";
      MySqlDataReader rdr = getStylistClientList.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        int id1 = rdr.GetInt32(0);
        int stylistId = rdr.GetInt32(1);
        string name = rdr.GetString(2);

        Client newClient = new Client(name, stylistId, id1);
        stylistClients.Add(newClient);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return stylistClients;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM client";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public override bool Equals(System.Object otherClient)
    {
      if (!(otherClient is Client))
      {
        return false;
      }
      else
      {
        Client newClient = (Client) otherClient;
        bool idEquality = (this.Id == newClient.Id);
        bool nameEquality = (this.Name == newClient.Name);
        bool stylistIdEquality = (this.StylistId == newClient.StylistId);
        return (idEquality && nameEquality && stylistIdEquality);
      }
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO `client` (`name`, `stylistId`) VALUES (@ClientName, @ClientStylistId);";

      MySqlParameter name = new MySqlParameter();
      name.ParameterName = "@ClientName";
      name.Value = this.Name;

      MySqlParameter stylistId = new MySqlParameter();
      stylistId.ParameterName = "@ClientStylistId";
      stylistId.Value = this.StylistId;

      cmd.Parameters.Add(name);
      cmd.Parameters.Add(stylistId);
      cmd.ExecuteNonQuery();
      Id = (int) cmd.LastInsertedId;
      // more logic will go here in a moment
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }


    public static Client Find(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM `client` WHERE id = @thisId;";
      MySqlParameter thisId = new MySqlParameter();
      thisId.ParameterName = "@thisId";
      thisId.Value = id;
      cmd.Parameters.Add(thisId);
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      string name = "";
      int stylistId = 0;
      int clientId = 0;


      while (rdr.Read())
      {
        clientId = rdr.GetInt32(0);
        stylistId = rdr.GetInt32(1);
        name = rdr.GetString(2);
      }

      Client foundClient = new Client(name, stylistId, clientId);
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return foundClient;
    }

    public void Edit(string name)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"UPDATE `client` SET name = @name WHERE id = @searchId;";
      MySqlParameter searchId = new MySqlParameter();
      searchId.ParameterName = "@searchId";
      searchId.Value = Id;
      cmd.Parameters.Add(searchId);
      MySqlParameter description = new MySqlParameter();
      description.ParameterName = "@name";
      description.Value = name;
      cmd.Parameters.Add(description);
      cmd.ExecuteNonQuery();
      Name = name;
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
  }
}
