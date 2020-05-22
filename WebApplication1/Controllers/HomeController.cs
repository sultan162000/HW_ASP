using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        PersonRepository person = new PersonRepository();
        List<Person> list = null;
        public ViewResult Index()
        {
            list = person.GetUsers();

            ViewBag.Greeting = list.Count;
            return View(list);
        }
    }
}