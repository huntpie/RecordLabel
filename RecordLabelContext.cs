
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;


namespace RecordLabel
{
  class RecordLabelContext : DbContext
  {
    public DbSet<Band> Bands { get; set; }
    public DbSet<Album> Albums { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql("server=localhost;database=RecordLabel");
      var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
      optionsBuilder.UseLoggerFactory(loggerFactory);
    }
  }
}