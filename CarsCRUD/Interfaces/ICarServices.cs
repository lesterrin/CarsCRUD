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
        IEnumerable<Car> GetCar { get; }
        Car FindCar(int id);
        void AddCar(Car car);
        void RemoveCar(Car car);
        bool AnyCar(int id);
        void UpdateCar(Car car);
    }
}
