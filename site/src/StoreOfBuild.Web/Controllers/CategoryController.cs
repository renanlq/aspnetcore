﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Web.Models;
using StoreOfBuild.Domain.VOs;
using StoreOfBuild.Domain;
using StoreOfBuild.Web.ViewModel;

namespace StoreOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStorer _caregoryStorer;

        public CategoryController(CategoryStorer categoryStorer)
        {
            _caregoryStorer = categoryStorer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryViewModel category)
        {
            _caregoryStorer.Store(category.Id, category.Name);
            return View();
        }
    }
}
