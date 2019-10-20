using CarsCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsCRUD.Services
{
    public class SampleData
    {
        public static void Initialize(CarContext context)
        {
            if (!context.Cars.Any()) 
            {
                context.Cars.AddRange(
                    new Car
                    {
                        CarName = "Москвич",
                        CarDesc = "Неубиваемая тарахтелка",
                        CarPrice = 100
                    },
                    new Car
                    {
                        CarName = "Тойота Саксид",
                        CarDesc = "Мал да удал",
                        CarPrice = 550
                    },
                    new Car
                    {
                        CarName = "Субару Легаси",
                        CarDesc = "Хорош",
                        CarPrice = 500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
