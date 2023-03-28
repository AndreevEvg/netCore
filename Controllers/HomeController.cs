using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Razor.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Controllers;

public class HomeController : Controller
{
    public IRepository Repository = SimpleRepository.SharedRepository;

    public IActionResult Index() => View(Repository.Products);

    [HttpGet]
    public IActionResult AddProduct() => View(new Product());

    [HttpPost]
    public IActionResult AddProduct(Product p)
    {
        Repository.AddProduct(p);
        return RedirectToAction("Index");
    }
}