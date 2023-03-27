using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Razor.Models;
using System.Threading.Tasks;

namespace Razor.Controllers;

public class HomeController : Controller
{
    private SimpleRepository Repository = SimpleRepository.SharedRepository;

    public IActionResult Index() => View(
        Repository.Products.Where(p => p.Price < 50)
    );

    [HttpGet]
    public IActionResult AddProduct() => View(new Product());

    [HttpPost]
    public IActionResult AddProduct(Product p)
    {
        Repository.AddProduct(p);
        return RedirectToAction("Index");
    }
}