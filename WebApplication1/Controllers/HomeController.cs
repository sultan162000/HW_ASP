using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        PersonRepository person = new PersonRepository();
        List<Person> list = null;

        public ViewResult Index()
        {
            list = person.GetUsers();
            return View(list);
        }
        
        public ViewResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(Person p)
        {
            if (ModelState.IsValid)
            {
                person.AddU(p);
                return RedirectToAction("Index");
            }
            return View();
            
        }

        public async Task<IActionResult> Search(string res)
        {
            IEnumerable<Person> me = null;
            bool isNum = int.TryParse(res, out int num);
            if (isNum)
                me = person.GetUsers().Where(m => m.Id.ToString().Contains(res));
            else
                me = person.GetUsers().Where(m => m.FirstName.Contains(res));

            return View("Index", await Task.FromResult(me));
            
        }
    }
}