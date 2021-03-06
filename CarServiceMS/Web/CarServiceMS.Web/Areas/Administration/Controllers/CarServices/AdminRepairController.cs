﻿using AutoMapper;
using CarServiceMS.Services.Interfaces.CarInterfaces;
using CarServiceMS.Web.ViewModels.CarServicesViewModels;
using CarServiceMS.Web.ViewModels.CarServicesViewModels.RepairViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarServiceMS.Web.Areas.Administration.Controllers.CarServices
{
    [Authorize(Roles = "Admin")]
    [Area("Administration")]
    public class AdminRepairController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRepairServices repairServices;

        public AdminRepairController(IMapper mapper, IRepairServices repairServices)
        {
            this.mapper = mapper;
            this.repairServices = repairServices;
        }


        [HttpGet]
        public IActionResult ListServiceCategories(int carId)
        {
            var repairsCount = this.repairServices.GetAllRepairsForCarWithId(carId).Count();

            var serviceCategoriesViewModel = new ServiceCategoriesViewModel()
            {
                RepairsCount = repairsCount
            };

            this.ViewData["carId"] = carId;

            return this.View(serviceCategoriesViewModel);
        }
        [HttpGet]
        public IActionResult ListAllRepairs(int carId)
        {
            var repairServiceModels = this.repairServices.GetAllRepairsForCarWithId(carId)
                .OrderBy(repairServiceModel => repairServiceModel.Date)
                .ToList();


            var repairListingViewModels = repairServiceModels
                .Select(repairServiceModel => this.mapper.Map<RepairListingViewModel>(repairServiceModel)).ToList();

            var repairListWithListingViewModels = new RepairListWithListingViewModels()
            {

            };

            return this.View(repairListWithListingViewModels);
        }
        [HttpGet]
        public IActionResult ShowRepairDetails(int repairId)
        {
            var repairServiceModel = this.repairServices.GetRepairById(repairId);
            var repairViewModel = this.mapper.Map<RepairDetailsViewModel>(repairServiceModel);

            return this.View(repairViewModel);
        }

        public IActionResult CreateRepair(int carId)
        {
            return this.View();
        }
        
    }
}
