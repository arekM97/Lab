using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using labki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
public class ProductsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(ProductModel product)
    {
        var viewModel = new ProductStatsViewModel
        {
            NameLength = product.Name.Length,
            DescriptionLength = product.Description.Length,
        };
        return View(viewModel);
    }



}