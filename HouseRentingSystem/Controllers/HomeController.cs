﻿using HouseRentingSystem.Web.ViewModels;
using HouseRentingSystem.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HouseRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHouseService houseService;
        public HomeController(IHouseService houseService)
        {
            this.houseService = houseService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await houseService.LastThreeHousesAsync();

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}