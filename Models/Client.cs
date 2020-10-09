using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Salon.Models
{
  public class Client
  {

    public int ClientId { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Address { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}