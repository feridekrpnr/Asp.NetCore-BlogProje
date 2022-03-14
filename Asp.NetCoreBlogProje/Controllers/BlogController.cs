﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id; //gönderdiğimiz idyi yazdırma işlemi
            var values = bm.GetBlogByID(id);
            return View(values); //dışarıdan aldıgı id ye gore işlemlerimizi gerçekleştirecek
        }
        public IActionResult GetBlogListByWriter()
        {
            var values = bm.GetBlogListByWriter(1); //yazara göre blog getir
            return View(values);
        }

    }
}
