using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace RecordLabel
{
  class Band
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CountryOfOrigin { get; set; }
    public int NumberOfMembers { get; set; }
    public string Website { get; set; }
    public string Style { get; set; }
    public Boolean IsSigned { get; set; }
    public string ContactName { get; set; }
    public string ContactPhoneNumber { get; set; }

    //Band has many albums
    public List<Album> Albums { get; set; }

    

    

  }
} 