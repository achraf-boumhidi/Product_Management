using System;
using Produt_Management.Models.Repository;
using Produt_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Produt_Management.Controllers
{
    public class ProductController:Controller
    {

        public ICompanyRepository<Product> _repo;

        public ProductController(ICompanyRepository<Product> repo)
        {
            _repo = repo;
        }


        public IActionResult Index()
        {
            IEnumerable<Product> products = _repo.GetAll();

            return View(products);
        }

        [HttpGet]

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(Product entity)
        {
            _repo.Add(entity);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Product product = _repo.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product entity)
        {
            _repo.Update(entity);
            return RedirectToAction("Details");
        }

        public IActionResult Details(int id)
        {
           Product product =  _repo.Get(id);
            return View(product);
        }
    }
}

