using Cars.Data.Models;

namespace Cars.Data
{
    public class AppDbInitializer
    {
        public static void Seed (IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Cars.Any())
                {
                    context.Cars.AddRange(new Car()
                    {
                        Id=1,
                        Name = "BMW",
                        Description = "New",
                        isSold = false,
                        SoldTime = DateTime.Now,
                        Rate = 10,
                        Country = "Germany",
                        Brand = "E34",
                        URL = "URL",
                        DateAdded = DateTime.Now

                    },
                    new Car()
                    {
                        Id=2,
                        Name = "BMW",
                        Description = "New",
                        isSold = false,
                        SoldTime = DateTime.Now,
                        Rate = 10,
                        Country = "Germany",
                        Brand = "E34",
                        URL = "URL",
                        DateAdded = DateTime.Now
                    },
                    new Car()
                    {
                        Id=3,
                        Name = "BMW",
                        Description = "New",
                        isSold = false,
                        SoldTime = DateTime.Now,
                        Rate = 10,
                        Country = "Germany",
                        Brand = "E34",
                        URL = "URL",
                        DateAdded = DateTime.Now
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
