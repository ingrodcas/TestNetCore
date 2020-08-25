using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Model;
using Service;
using Test.Models;

namespace Test.Controllers
{
    public class PermitsController : Controller
    {
        private readonly IPermitsService _permitsservice;
       
        public PermitsController(IPermitsService permitsservice)
        {
            _permitsservice = permitsservice;
        }
       
        public IActionResult Index()
        {
            return View(_permitsservice.Index());
        }
        public IActionResult Details(int? id)
        {
            return View(_permitsservice.Details(id));
        }
        public IActionResult Delete(int? id)
        {
            return View(_permitsservice.Details(id));
        }
        public IActionResult Edit(int? id)
        {
            return View(_permitsservice.Details(id));
        }
        public IActionResult Create()
        {
            ViewData["PermissionType"] = new SelectList(_permitsservice.GetPermissionType(), "Id", "Description");
            return View();
        }


        [HttpPost]
        public IActionResult Edit(PermitsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", model);
            }
            var type = new Permits
            {
                Id = model.Id,
                EmployeeName = model.EmployeeName,
                EmployeeLastName = model.EmployeeLastName,
                PermissionType = model.PermissionType,
                PermitDate = model.PermitDate
            };

            _permitsservice.Edit(type);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Insert(PermitsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }
            var type = new Permits
            {
                EmployeeName = model.EmployeeName,
                EmployeeLastName = model.EmployeeLastName,
                PermissionType = model.PermissionType,
                PermitDate = model.PermitDate
            };

            _permitsservice.Create(type);

            return RedirectToAction("Index");


        }
        [HttpPost]
        public IActionResult Delete(PermitsViewModel model)
        {

            var type = new Permits
            {
                Id = model.Id,
                EmployeeName = model.EmployeeName,
                EmployeeLastName = model.EmployeeLastName,
                PermissionType = model.PermissionType,
                PermitDate = model.PermitDate
            };

            _permitsservice.Delete(type);

            return RedirectToAction("Index");


        }

    }
}
