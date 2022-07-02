using System.Data.Entity;
using System.Linq;
using RobertaStone.Models;
using System.Web.Mvc;
using RobertaStone.ViewModels;

namespace RobertaStone.Controllers
{
    public class LexisController : Controller
    {
        private ApplicationDbContext _context;

        public LexisController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();   
        }

        public ActionResult New()
        {
            var contentTypes = _context.ContentTypes.ToList();
            var languages = _context.Languages.ToList();
            var conversationPartners = _context.ConversationPartners.ToList();
            var lexisTypes = _context.LexisTypes.ToList();

            var viewModel = new LexisFormViewModel()
            {
                ContentTypes         = contentTypes,
                Languages            = languages,
                ConversationPartners = conversationPartners,
                LexisTypes           = lexisTypes, 
            };

            return View("LexisForm", viewModel);
        }     
        public ViewResult ShowLexis()
        {
            /* below doesn't query the database, this is used when we are iterating below
                this is called deferred execution, to directly query the db add ToList() at the end
            */
            var lexis = _context.Lexis
                .Include(l  => l.Language)
                .Include(cp =>cp.ConversationPartner)
                .Include(ct => ct.ContentType)
                .Include(lt =>lt.LexisType);

            return View(lexis);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveLexis(Lexis lexis)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new LexisFormViewModel(lexis)
                {
                    Languages = _context.Languages.ToList(),
                    ContentTypes = _context.ContentTypes.ToList(),
                    ConversationPartners = _context.ConversationPartners.ToList(),
                    LexisTypes = _context.LexisTypes.ToList()
                };

                return View("LexisForm", viewModel);
            }
            if (lexis.id == 0)
                _context.Lexis.Add(lexis);
            else
            {
                var lexisInDb = _context.Lexis.Single(l => l.id == lexis.id);

                lexisInDb.LexisContent = lexis.LexisContent;
                lexisInDb.DateLearnt = lexis.DateLearnt;
                lexisInDb.TimeLearnt = lexis.TimeLearnt;
                lexisInDb.LexisTypeId = lexis.LexisTypeId;
                lexisInDb.ContentTypeId = lexis.ContentTypeId;
                lexisInDb.ConversationPartnerId = lexis.ConversationPartnerId;
            }

            _context.SaveChanges();
            return RedirectToAction("ShowLexis", "Lexis");

        }

        public ActionResult Edit(int id)
        {
            var lexis = _context.Lexis.SingleOrDefault(l => l.id == id);

            if (lexis == null)
                return HttpNotFound();

            var viewModel = new LexisFormViewModel(lexis)
            {
                Languages = _context.Languages.ToList(),
                ConversationPartners = _context.ConversationPartners.ToList(),
                ContentTypes = _context.ContentTypes.ToList(),
                LexisTypes = _context.LexisTypes.ToList()
            };

            return View("LexisForm", viewModel);
        }
    }
}