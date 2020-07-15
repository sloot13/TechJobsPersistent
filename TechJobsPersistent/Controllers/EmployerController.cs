﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext _context;
        public EmployerController(JobDbContext context)
        {
            _context = context;
        }
        // GET: /Employer
        public IActionResult Index()
        {
            List<Employer> employers = _context.Employers.ToList();
            return View(employers);
        }

        //GET: /Employer/ADD
        public IActionResult Add()
        {
            AddEmployerViewModel viewModel = new AddEmployerViewModel();
            return View(viewModel);
        }

        //POST: /Employer/ProcessAddEmployerForm
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                Employer employer = new Employer
                {
                    Name = viewModel.Name,
                    Location = viewModel.Location
                };
                _context.Employers.Add(employer);
                _context.SaveChanges();

                return Redirect("/Home");
            }

            return View("Add", viewModel);
        }

        //Get: /Employer/About/{id}
        public IActionResult About(int id)
        {
            Employer employer = _context.Employers.Find(id);
            return View(employer);
        }
    }
}
