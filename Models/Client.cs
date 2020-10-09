using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Salon.Models
{
  public class Client
  {

    public int ClientId { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public int StylistId { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Email { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}