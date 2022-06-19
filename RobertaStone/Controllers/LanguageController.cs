using System.Linq;
using System.Web.Mvc;
using RobertaStone.Models;

namespace RobertaStone.Controllers
{
    public class LanguageController : Controller
    {
        private ApplicationDbContext _context;

        public LanguageController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult AvailableLanguage()
        {
            var languages =_context.Languages;

            return View(languages);
        }
    }
}