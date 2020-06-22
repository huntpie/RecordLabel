using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;




namespace RecordLabel
{
  class Album
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public Boolean isExplicit { get; set; }
    public DateTime ReleaseDate { get; set; }

    public int BandId { get; set;}
    public Band Band { get; set;}


  }
}