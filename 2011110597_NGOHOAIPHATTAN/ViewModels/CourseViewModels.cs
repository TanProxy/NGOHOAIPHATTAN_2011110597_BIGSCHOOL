using _2011110597_NGOHOAIPHATTAN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2011110597_NGOHOAIPHATTAN.ViewModels
{
    public class CourseViewModels
    {
        [Required]
        public string Place { get; set; }
        
        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }  
        public IEnumerable<Category> categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}",Date, Time));
        }
    }
}