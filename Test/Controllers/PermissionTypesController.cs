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
    public class PermissionTypesController : Controller
    {
        private readonly IPermissionTypesService _permissiontypesservice;
        public PermissionTypesController(IPermissionTypesService permissiontypesservice)
        {
            _permissiontypesservice = permissiontypesservice;
        }

      
        public IActionResult Index()
        {
            return View(_permissiontypesservice.Index());
        }
        public IActionResult Details(int? id)
        {
            return View(_permissiontypesservice.Details(id));
        }
        public IActionResult Delete(int? id)
        {
            return View(_permissiontypesservice.Details(id));
        }
        public IActionResult Edit(int? id)
        {
            return View(_permissiontypesservice.Details(id));
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Edit(PermissionTypesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", model);
            }
            var type = new PermissionType
            {
                Id = model.Id,
                Description = model.Description
            };

            _permissiontypesservice.Edit(type);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Insert(PermissionTypesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }
            var type = new PermissionType
            {
                Description = model.Description
            };

            _permissiontypesservice.Create(type);

            return RedirectToAction("Index");


        }
        [HttpPost]
        public IActionResult Delete(PermissionTypesViewModel model)
        {
         
            var type = new PermissionType
            {
                Id = model.Id,
                Description = model.Description
            };

            _permissiontypesservice.Delete(type);

            return RedirectToAction("Index");


        }
    }
}
