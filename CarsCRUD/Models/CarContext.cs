using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsCRUD.Models
{
    public class CarContext: DbContext
    {
        public CarContext(DbContextOptions<CarContext> options): base(options) //?Что значат параметры конструктора? Для чего необходим? 
        {

        }
        public DbSet<Car> Cars { get; set; } //связывается с базой данных? Содержит возвращаемые из БД значения?
    }
}
