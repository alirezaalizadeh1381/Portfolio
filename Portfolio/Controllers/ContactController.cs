using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly PortfolioWebsiteDbContext _context;

        public ContactController(PortfolioWebsiteDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.SubmittedAt = DateTime.Now;
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                ViewBag.Message = "Thank you for your message!";
                return View("Index");
            }

            return View("Index", contact);
        }
    }
}
