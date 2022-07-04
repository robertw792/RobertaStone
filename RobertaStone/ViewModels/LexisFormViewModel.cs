using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RobertaStone.Dtos;
using RobertaStone.Models;

namespace RobertaStone.ViewModels
{
    public class LexisFormViewModel
    {
        public IEnumerable<ContentType> ContentTypes                 { get; set; }
        public IEnumerable<Language> Languages                       { get; set; }
        public IEnumerable<ConversationPartner> ConversationPartners { get; set; }
        public IEnumerable<LexisType> LexisTypes                     { get; set; }
        public int? id { get; set; }

        [Display(Name = "Language")]
        public int LanguageId { get; set; }

        [Display(Name = "Conversation Partner")]
        public int? ConversationPartnerId { get; set; }

        [Display(Name = "Content Type")]
        public int ContentTypeId { get; set; }

        [Display(Name = "Lexis Type")]
        public int LexisTypeId { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Content")]
        public string LexisContent { get; set; }

        [Display(Name = "Date Learnt")]
        [DateLearntNotInFuture]
        public DateTime DateLearnt { get; set; }

        [Display(Name = "Time Learnt")]
        public TimeSpan? TimeLearnt { get; set; }

        public LexisFormViewModel()
        {
            id = 0;
        }

        public LexisFormViewModel(LexisDto lexisDto)
        {
            id                    = lexisDto.id;
            LexisContent          = lexisDto.LexisContent;
            DateLearnt            = lexisDto.DateLearnt;
            TimeLearnt            = lexisDto.TimeLearnt;
            LanguageId            = lexisDto.LanguageId;
            LexisTypeId           = lexisDto.LexisTypeId;
            ContentTypeId         = lexisDto.ContentTypeId;
            ConversationPartnerId = lexisDto.ConversationPartnerId;
        }
    }
}