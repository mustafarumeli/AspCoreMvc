using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSiteWithCore.Classes;
using BlogSiteWithCore.Classes.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogSiteWithCore.Controllers
{
    public class BlogController : Controller
    {
        IRepository<Blog> _db;
        public BlogController(IRepository<Blog> db)
        {
            _db = db;
        }
        public IActionResult Blogs()
        {
            return View(_db.GetList());
        }

        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBlog(Blog blog)
        {
            _db.Add(entity: blog);
            return View();
        }
    }
}