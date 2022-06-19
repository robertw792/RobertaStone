using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RobertaStone.Models;

namespace RobertaStone.Controllers
{
    public class ConversationPartnerController : Controller
    {
        // GET: ConversationPartner
        public ActionResult Index()
        {
            var conversationPartner = GetConversationPartners();

            return View(conversationPartner);
        }

        private IEnumerable<ConversationPartner> GetConversationPartners()
        {
            return new List<ConversationPartner>
            {
                new ConversationPartner
                {
                    ConversationPartnerId        =  1,
                    PartnerFirstName             = "Stephane",
                    PartnerLastName              = "Baener"
                },
                new ConversationPartner
                {
                    ConversationPartnerId        = 2,
                    PartnerFirstName             = "Amelie",
                    PartnerLastName              = "Dupoint"
                }
            };
        }

        public ActionResult Details(int id)
        {
            var conversationPartner = GetConversationPartners().SingleOrDefault(c => c.ConversationPartnerId == id);

            if (conversationPartner == null)
                return HttpNotFound();

            return View(conversationPartner);
        }
    }
}