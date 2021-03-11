using IMS_with_Repository_Pattern_DbFirst.Models;
using IMS_with_Repository_Pattern_DbFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS_with_Repository_Pattern_DbFirst.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public ActionResult Index()
        {
            return View(categoryRepository.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryRepository.Insert(category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult Edit(Category category)
        {
            _ = category.CategoryId;
            categoryRepository.Update(category);
            return RedirectToAction("Index");
        }*/
    }
}