using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using labki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[Route("api/products")]
public class ProductsApiController : ControllerBase
{
    [HttpPost]
    public IActionResult Add(ProductModel product)
    {
        return Ok();
    }
}