﻿using CarServiceMS.Data.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarServiceMS.Data.Interfaces
{
    public interface ICarService
    {
        Car GetCarById(int id);
        ApplicationUser GetUserByName(string id);
        void AddCar(Car car);
        Task RemoveCar(int id);
        void UpdateCarData(int id);

        IEnumerable<Car> GetAllCars(string userId);


    }
}
