using System;
using System.Linq;
using System.Threading.Tasks;

namespace LinqCollection
{
   class Program
   {
      static async Task Main(string[] args)
      {
         await using var dbContext = new ApplicationDbContext();

      }
   }
}
