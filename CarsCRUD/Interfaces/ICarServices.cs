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
        void Remove(Car car);
        bool Any(int id);
        void Update(Car car);
    }
}
