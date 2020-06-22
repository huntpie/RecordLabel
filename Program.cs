using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RecordLabel
{
  class Program
  {
    static void Main(string[] args)
    {
      var context = new RecordLabelContext();

      var albums = context.Albums;

      var bands = context.Bands;

      DateTime linkinParkReleaseDate = new DateTime(2004, 11, 30);

      var newBand = new Band
      {
        Name = "Linkin Park",
        CountryOfOrigin = "USA",
        NumberOfMembers = 5,
        Website = "linkinpark.com",
        Style = "rock",
        IsSigned = true,
        ContactName = "Band Manager Bill",
        ContactPhoneNumber = "813-777-3434"
      };

      var newAlbum = new Album
      {
        Title = "Collision Course",
        isExplicit = true,
        ReleaseDate = linkinParkReleaseDate,
        BandId = 0
      };

      //context.Bands.Add(newBand);
      //context.SaveChanges();

      //context.Albums.Add(newAlbum);
      //context.SaveChanges();

      foreach (var band in bands)
      {
        if (band.Name == "Linkin Park")
        {
          newAlbum.BandId = band.Id;
        }
        Console.WriteLine($"{band.Name}");
      }



      var existingBand = context.Bands.FirstOrDefault(band => band.Name == "Linkin Park");


      if (existingBand != null)
      {
        existingBand.IsSigned = false;
        context.SaveChanges();
      }

      if (existingBand != null)
      {
        existingBand.IsSigned = true;
        context.SaveChanges();
      }

      Console.WriteLine("Would you like to view the albums of a band? Y or N?");

      var userAnswer = Console.ReadLine();

      {
        if (userAnswer == "Y")
        {
          Console.WriteLine("Please input a band name from our list of bands");
          var userAnswerBandName = Console.ReadLine();
          var userBand = context.Bands.FirstOrDefault(band => band.Name == userAnswerBandName);
          Console.WriteLine($"Here are the albums for {userAnswerBandName}");

          foreach (var album in albums)
          {
            if (userBand != null)
            {
              Console.WriteLine($"Album is {album.Title}");
            }
          }
        }
        else
        {
          Console.WriteLine("Thanks for using the program");
        }
      }
      var existingAlbum = context.Albums.OrderBy(album => album.ReleaseDate);

      foreach (var album in existingAlbum)
      {
        Console.WriteLine($"{album.Title} , {album.ReleaseDate} ");
      }

      Console.WriteLine("Here is a view of Bands that are signed");

      foreach (var band in bands)
      {
        if (band.IsSigned == true)
        {
          Console.WriteLine($"{band.Name} , Is Signed: {band.IsSigned} ");
        }
      }

      Console.WriteLine("Here is a view of Bands that are NOT signed");

      foreach (var band in bands)
      {
        if (band.IsSigned != true)
        {
          Console.WriteLine($"{band.Name} , Is Signed: {band.IsSigned} ");
        }
      }
    }
  }
}










