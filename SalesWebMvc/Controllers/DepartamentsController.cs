﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletronicts" });
            list.Add(new Departament { Id = 2, Name = "Fashion" });
            return View(list);
        }
    }
}
