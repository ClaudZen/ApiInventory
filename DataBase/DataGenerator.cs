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
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationContext>>()))
            {
                var categories = new Category[]
             {
                new Category {Id=1,Name="Parlante",Order=1,RegistrationDate=new DateTime(),State="Deshabilitado"},
                new Category {Id=2,Name="Mouse",Order=2,RegistrationDate=new DateTime(),State="Habilitado"},
                new Category {Id=3,Name="Teclado",Order=3,RegistrationDate=new DateTime(),State="Deshabilitado"},
                new Category {Id=4,Name="Cables",Order=4,RegistrationDate=new DateTime(),State="Habilitado"}
             };
                context.Categories.AddRange(categories);

                context.SaveChanges();
            }
        }
    }
}
