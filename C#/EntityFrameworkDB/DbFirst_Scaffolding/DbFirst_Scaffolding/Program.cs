using DbFirst_Scaffolding.Models;
using Microsoft.EntityFrameworkCore;

namespace DbFirst_Scaffolding
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            PubsContext context = new PubsContext();

            var list = await context.Authors.ToListAsync();

            foreach (var item in list)
            {
                Console.WriteLine(item.Address);
            }
        }
    }
}