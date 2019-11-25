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
        List<Car> GetCar();
        Car FindCar(int id);
        Task AddCar(Car car);
        Task RemoveCar(Car car);
        bool AnyCar(int id);
        Task UpdateCar(Car car);
    }
}
