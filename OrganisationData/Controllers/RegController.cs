using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganisationData.Models;

namespace OrganisationData.Controllers
{
    public class RegController : Controller
    {
        private readonly AppUser _auc;
        public RegController(AppUser auc)
        {
            _auc = auc;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserReg uc)
        {

            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The user" + uc.Fname + "Registered";
            return View();
        }
    }
}
