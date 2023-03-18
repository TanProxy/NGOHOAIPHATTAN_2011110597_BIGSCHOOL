﻿using _2011110597_NGOHOAIPHATTAN.Models;
using _2011110597_NGOHOAIPHATTAN.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2011110597_NGOHOAIPHATTAN.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModels
            {
                categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (CourseViewModels viewModels)
        {
            if (!ModelState.IsValid)
            {
                viewModels.categories= _dbContext.Categories.ToList();
                return View("Create",viewModels);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DataTime = viewModels.GetDateTime(),
                CategoryId =  viewModels.Category,
                Place = viewModels.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index" , "Home");

            
        }

    }
}