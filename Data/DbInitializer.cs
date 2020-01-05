using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BallGameMVC.Models;

namespace BallGameMVC.Data
{
    public class DbInitializer
    {
        public static void Initialize (BallGameDBContext context)
        {
            context.Database.EnsureCreated();
            
            //Looking for any locations
            if(context.Environs.Any())
            {
                return; //DB has been seeded
            }

            var environs = new Environ[]
            {
                new Environ{EnvName = "Test Field", EnvLocation = "Kingston", EnvTurfType = "Grass", EnvRegistrationDate = DateTime.Parse("2020-01-01") }
            };
            foreach (Environ e in environs)
            {
                context.Environs.Add(e);
            }
            context.SaveChanges();
        }
    }
}
