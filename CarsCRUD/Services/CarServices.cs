﻿using CarsCRUD.Models;
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
            this._context = context;
        }

        public IEnumerable<Car> GetCar
        {
            get
            {
                return _context.Cars.ToList();
            }
        }


        public Car FindCar(int id)
        {
            return _context.Cars.Find(id);
        }

        public void AddCar(Car car)
        {
            _context.Add(car);
            _context.SaveChangesAsync();
        }
        public void Remove(Car car)
        {
            _context.Cars.Remove(car);
            _context.SaveChangesAsync();
        }
        public void Update(Car car)
        {
            _context.Update(car);
            _context.SaveChangesAsync();
        }

        public bool Any(int id)
        {
            return _context.Cars.Any(e => e.CarID == id);
        }
    }
}
