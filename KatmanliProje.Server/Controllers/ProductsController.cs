using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KatmanliProje.Business.Classes;
using KatmanliProje.Business.Interfaces;
using KatmanliProje.Repository.Classes;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliProje.Server.Controllers
{
    public class ProductsController : Controller
    {
        IProductsService _proService;
        public ProductsController(IProductsService proService )
        {
            _proService = proService;
        }
        public IActionResult Index()
        {

            return Json(_proService.GetProducts());
        }
    }
}