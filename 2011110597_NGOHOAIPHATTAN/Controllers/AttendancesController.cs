using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Mvc;
using _2011110597_NGOHOAIPHATTAN.Models;
using Microsoft.AspNet.Identity;
using _2011110597_NGOHOAIPHATTAN.DTOs;

namespace _2011110597_NGOHOAIPHATTAN.Controllers
{
    [System.Web.Http.Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }




        [System.Web.Http.HttpPost]
        public IHttpActionResult Attend (AttendanceDto attendanceDto)
        {
            var userID = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId== userID && a.CourseId == attendanceDto.CourseId)) { }

            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userID
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
