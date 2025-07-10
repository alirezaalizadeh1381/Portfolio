using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Sample project data (in-memory for simplicity)
            var projects = new List<Project>
            {
                new Project {Id =1 , Title = "Project one" , Description = "A web app built with ASP.NET Core." , ImageUrl="/images/images.jpg"},
                new Project {Id=2 , Title = "Project two", Description="A mobile app using Flutter", ImageUrl="/images/Project_2.jpg"},
                new Project {Id=3 , Title = "Project three" , Description="A web project for taking test", ImageUrl="/images/Project_3.jpg"}
            };

            return View(projects);
        }
    }
}
