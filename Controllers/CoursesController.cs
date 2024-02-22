using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace uppgift1
{
   
        public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CoursesController(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
            List<Course> objCoursesList=_db.Courses.ToList();

            return View(objCoursesList);
        }

    }
}