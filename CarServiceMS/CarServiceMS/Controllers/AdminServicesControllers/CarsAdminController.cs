﻿using CarServiceMS.Data;
using CarServiceMS.Data.Interfaces;
using CarServiceMS.Data.Models;
using CarServiceMS.Models.BindingModels;
using CarServiceMS.Models.BindingModels.AdminServices;
using CarServiceMS.Models.CarModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CarServiceMS.Controllers.AdminServicesControllers
{
    [Authorize(Roles = "Admin")]
    public class CarsAdminController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IAdminService adminService;
        private readonly ICarService carService;

        public CarsAdminController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
                               RoleManager<IdentityRole> roleManager, IAdminService adminService,
                               ICarService carService)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.adminService = adminService;
            this.carService = carService;
        }

        public IActionResult ListAllCars()
        {
            var carsFromDb = this.adminService.GetAllCars();

            var carsBinding = carsFromDb.Select(car => new CarBindingModel()
            {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                YearFrom = car.YearFrom,
                Number = car.Number,
                RegistredOn = car.RegistredOn,
                Owner = car.Owner
            });


            var cars = new CarListingModel()
            {
                Cars = carsBinding
            };

            return this.View(cars);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveCar(UsersCarsListingModel model)
        {
            var carId = model.Id;
            var password = model.Password;
            var user = this.carService.GetUserByCarId(carId);
            var admin = await this.userManager.GetUserAsync(this.User);

            var isPasswordValid = false;

            if (password != null)
            {
                isPasswordValid = await userManager.CheckPasswordAsync(admin, password);

            }

            if (this.ModelState.IsValid && isPasswordValid)
            {
                this.carService.RemoveCar(model.Id);


                return this.RedirectToAction($"ListAllCars", "CarsAdmin");



            }
            else
            {
                if (isPasswordValid == false)
                {
                    ModelState.AddModelError(string.Empty, "Ivalid Password!");
                    return this.RedirectToAction($"ListAllCars", "CarsAdmin");

                }
                else
                {
                    return this.RedirectToAction($"ListAllCars", "CarsAdmin");

                }
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var carFromDb = this.carService.GetCarById(id);

            var car = new EditCarBindingModel()
            {
                Brand = carFromDb.Brand,
                Model = carFromDb.Model,
                YearFrom = carFromDb.YearFrom,
                Number = carFromDb.Number
            };

            return this.View(car);
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public IActionResult Edit(EditCarBindingModel carModel)
        {



            if (this.ModelState.IsValid)
            {
                var car = this.carService.GetCarById(carModel.Id);


                car.Brand = carModel.Brand;
                car.Model = carModel.Model;
                car.YearFrom = carModel.YearFrom;



                if (car.Number != carModel.Number)
                {
                    if (!this.carService.IsThereSuchCar(carModel.Number))
                    {
                        car.Number = carModel.Number;
                    }
                    else
                    {

                        ModelState.AddModelError("Number", "Invalid Number");
                        return this.View(carModel);
                    }
                }



                this.carService.EditCarData(car);

                return RedirectToAction("ListAllCars", "CarsAdmin");
            }
            else
            {

                ModelState.AddModelError("Number", "Invalid Number");
                return this.View(carModel);
            }


        }

    }
}
