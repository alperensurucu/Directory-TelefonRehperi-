/*using Microsoft.AspNetCore.Mvc;

namespace Directory.UI.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Directory()
		{
			return View();
		}
	}
}
*/
using Directory.DAL.Context;
using Directory.Model.Entities;
using Directory.BLL.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Directory.UI.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPersonRepository _personRepository;
        private readonly MyDbContext _context;

        public HomeController(IPersonRepository personRepository, MyDbContext context)
		{
			_personRepository = personRepository;
            _context = context;
        }

		public IActionResult Directory()
		{
			var people = _personRepository.GetActives();
			return View(people);
		}
        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
			{
                _context.Persons.Add(person);
                _context.SaveChanges();

                return RedirectToAction("Directory");
            }
            return View(person);
        }
    }
}