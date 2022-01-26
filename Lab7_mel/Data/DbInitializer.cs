using Lab7_mel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7_mel.Data
{
    public class DbInitializer
    {
        public static void Initialize(DBcarContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cars.Any())
            {
                return;   // DB has been seeded
            }

            var gener = new Generator[]
            {
                new Generator{Name = "Cadillac", Country = "USA", Capiral = 12458800},
                new Generator{Name = "Volkswagen", Country = "Germany", Capiral = 52654000},
                new Generator{Name = "Toyota", Country = "Japan", Capiral = 3540000}
            };
            foreach (Generator s in gener)
            {
                context.Generators.Add(s);
            }
            context.SaveChanges();

            var cars = new Car[]
            {
                new Car{Name = "Model 1", GeneratorID = 1, Year = 2001, Price = 1056568},
                new Car{Name = "Model 2", GeneratorID = 1, Year = 2012, Price = 65656},
                new Car{Name = "MOD_1", GeneratorID = 2, Year = 2007, Price = 265696},
                new Car{Name = "Ver. 3.45", GeneratorID = 3, Year = 1989, Price = 421355},
                new Car{Name = "Alfa-5", GeneratorID = 2, Year = 1972, Price = 238798},
                new Car{Name = "Model 5", GeneratorID = 1, Year = 2020, Price = 3000548},
            };
            foreach (Car s in cars)
            {
                context.Cars.Add(s);
            }
            context.SaveChanges();
        }
    }
}

