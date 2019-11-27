using CarsCRUD.Models;
using CarsCRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsCRUD.Interfaces
{
    public interface ICarServices
    {
        Task<List<Car>> GetCar();
        Task<Car> FindCar(int id);
        Task AddCar(Car car);
        Task RemoveCar(Car car);
        Task<bool> AnyCar(int id);
        Task UpdateCar(Car car);
    }
}
