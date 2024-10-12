using Microsoft.AspNetCore.Mvc;
using Portafolio.web.Models;
using Portafolio.web.Services;
using System.Diagnostics;

namespace Portafolio.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectRepository projectRepository;

        public HomeController(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public IActionResult Index()
        {
            var projects =projectRepository.GetProjects().Take(3).ToList();

            var model = new HomeIndexViewModel()
            {
                Projects = projects
            };
            return View(model);
        }
        public IActionResult Projects()
        {
            var projects = projectRepository.GetProjects();
            return View(projects);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel contactoViewModel)
        {
            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
