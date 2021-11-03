using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DataGenerator
    {
        public const string ENABLED = "Habilitado";
        public const string DISABLED = "Deshabilitado";

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationContext>>());

            var categories = new Category[]
            {
                    new Category {Id=1,Name="Parlante",Order=1,RegistrationDate=new DateTime(),State=DISABLED},
                    new Category {Id=2,Name="Mouse",Order=2,RegistrationDate=new DateTime(),State=ENABLED},
                    new Category {Id=3,Name="Teclado",Order=3,RegistrationDate=new DateTime(),State=DISABLED},
                    new Category {Id=4,Name="Cables",Order=4,RegistrationDate=new DateTime(),State=ENABLED}
            };

            var products = new Product[]
            {
                    new Product{Id=1,Name="MX1000",Price=5000,State=ENABLED,RegistrationDate=new DateTime(),Category=categories[1],Order=1 },
                    new Product{Id=2,Name="MX2000",Price=9000,State=ENABLED,RegistrationDate=new DateTime() ,Category=categories[1],Order=2},
                    new Product{Id=3,Name="PH1000",Price=4000,State=ENABLED,RegistrationDate=new DateTime(), Category=categories[3],Order=3},
                    new Product{Id=4,Name="PH2000",Price=9000,State=DISABLED,RegistrationDate=new DateTime(), Category=categories[3],Order=4},
                    new Product{Id=5,Name="PH3000",Price=15000,State=ENABLED,RegistrationDate=new DateTime() ,Category=categories[3],Order=5}
            };


            context.Categories.AddRange(categories);
            context.Products.AddRange(products);

            context.SaveChanges();
        }
    }
}
