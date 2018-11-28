using GeoPonto.Context;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace GeoPonto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new UserContext();
            context.Database.EnsureCreated();

            // BuildWebHost(args).Run();

            UserContext db = new UserContext();
            db.User.Add(new Model.User { Name = "Teste", Email = "email@email.com" });
            db.SaveChanges();

        }
         
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
