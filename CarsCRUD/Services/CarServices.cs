using CarsCRUD.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarsCRUD.Controllers;
using CarsCRUD.Interfaces;

namespace CarsCRUD.Services
{
    public class CarServices : ICarServices
    {
        private readonly CarContext _context;
        public CarServices(CarContext context)
        {
            _context = context;
        }
        
        public List<Car> GetCar()
        {
            return _context.Cars.ToList();
        }


        public Car FindCar(int id)
        {
            return _context.Cars.Find(id);
        }

        public async Task AddCar(Car car)
        {
            await _context.AddAsync(car);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveCar(Car car)
        {
            _context.Remove(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCar(Car car)
        {
          _context.Update(car);
           await _context.SaveChangesAsync();
                
        }

        public bool AnyCar(int id)
        {
            return _context.Cars.Any(e => e.CarID == id);
        }
    }
}
