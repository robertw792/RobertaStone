using System.Collections.Generic;
using RobertaStone.Models;

namespace RobertaStone.ViewModels
{
    public class LexisFormViewModel
    {
        public IEnumerable<ContentType> ContentTypes { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<ConversationPartner> ConversationPartners { get; set; }
        public Lexis Lexis { get; set; }
    }
}