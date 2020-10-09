using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Salon.Models
{
  public class Stylist
  {
    // public Stylist()
    // {
    //   this.Client = new HashSet<Client>();
    // }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Details { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

  }
}