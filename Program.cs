using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqCollection
{
   class Program
   {
      static async Task Main(string[] args)
      {
         // await using var dbContext = new ApplicationDbContext();      // C# 8.0
         // var myQueryableMovie = dbContext.Movies.AsQueryable();
         // myQueryableMovie = myQueryableMovie.Where(m => m.Id == 2);
         // var resultQueryable = myQueryableMovie.ToList();

         // var myEnumerableMovie = dbContext.Movies.AsEnumerable();
         // myEnumerableMovie = myEnumerableMovie.Where(m => m.Id == 2);
         // var resultEnumerable = myEnumerableMovie.ToList();
         // var myListMovie = dbContext.Movies.ToList();
         await foreach (var item in FetchIntegerAsyncEnumerable())
         {
            Console.WriteLine(item);
            if (item == 3)
            {
               break;
            }
         }
         Console.ReadLine();
      }

      static async IAsyncEnumerable<int> FetchIntegerAsyncEnumerable()
      {
         for (int i = 0; i < 10; i++)
         {
            await Task.Delay(1000);
            yield return i;
         }
      }
      static async Task<IEnumerable<int>> FetchIntegerAsync()
      {
         var result = new List<int>();
         for (int i = 0; i < 10; i++)
         {
            await Task.Delay(1000);
            result.Add(i);
         }
         return result;
      }

      static IEnumerable<int> FetchInteger()
      {
         for (int i = 0; i < 10; i++)
         {
            yield return i;
         }
      }

      static IList<int> FetchIntegerList()
      {
         var result = new List<int>();
         for (int i = 0; i < 10; i++)
         {
            result.Add(i);
         }
         return result;
      }
   }
}
