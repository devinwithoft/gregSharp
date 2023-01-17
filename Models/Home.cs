using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregSharp.Models;
public class Home
{
  public int Id { get; set; }
  public int? beds { get; set; }
  public int? baths { get; set; }
  public int? price { get; set; }
  public string description { get; set; }
  public string imgUrl { get; set; }

}
