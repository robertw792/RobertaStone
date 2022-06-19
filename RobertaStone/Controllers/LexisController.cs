﻿using System.Data.Entity;
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
            var viewModel = new LexisFormViewModel()
            {
                ContentTypes         = contentTypes,
                Languages            = languages,
                ConversationPartners = conversationPartners
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
                .Include(ct => ct.ContentType);

            return View(lexis);
        }

        [HttpPost]
        public ActionResult CreateLexis(Lexis lexis)
        {
            _context.Lexis.Add(lexis);
            _context.SaveChanges();

            return RedirectToAction("ShowLexis", "Lexis");

        }

        public ActionResult Edit(int id)
        {
            var lexis = _context.Lexis.SingleOrDefault(l => l.id == id);

            if (lexis == null)
                return HttpNotFound();

            var viewModel = new LexisFormViewModel
            {
                Lexis = lexis,
                Languages = _context.Languages.ToList(),
                ConversationPartners = _context.ConversationPartners.ToList(),
                ContentTypes = _context.ContentTypes.ToList()
            };

            return View("LexisForm", viewModel);
        }
    }
}