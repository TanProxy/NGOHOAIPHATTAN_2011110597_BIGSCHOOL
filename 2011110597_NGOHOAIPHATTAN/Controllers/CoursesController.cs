using _2011110597_NGOHOAIPHATTAN.Models;
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
      
        
        public ActionResult Create ()
        {
            var viewModel = new CourseViewModels
            {
                categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }

    }
}