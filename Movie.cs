﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinqCollection
{
   public class Movie
   {
      public int Id { get; set; }
      public string Title { get; set; }
      public DateTime ReleaseDate { get; set; }
      public string Genre { get; set; }
      public decimal Price { get; set; }

      public override string ToString()
      {
         return $"Movie ID:{Id} {Title} on {ReleaseDate} Type {Genre} @ {Price}";
      }
   }
}