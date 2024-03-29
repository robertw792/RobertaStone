﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RobertaStone.Models
{
    public class Lexis 
    {
        public int id                                  { get; set; }

        [Display(Name = "Language")]
        public int LanguageId                          { get; set; }

        [Display(Name = "Conversation Partner")]
        public int? ConversationPartnerId              { get; set; }

        [Display(Name = "Content Type")]
        public int ContentTypeId                       { get; set; }

        [Display(Name = "Lexis Type")]
        public int LexisTypeId                         { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Content")]
        public string    LexisContent                  { get; set; }

        [Display(Name = "Date Learnt")]
        [DateLearntNotInFuture]
        public DateTime  DateLearnt                    { get; set; }

        [Display(Name = "Time Learnt")]
        public TimeSpan? TimeLearnt                    { get; set; }

        public Language Language                       { get; set; }
        public ConversationPartner ConversationPartner { get; set; }
        public ContentType ContentType                 { get; set; }
        public LexisType LexisType                     { get; set; }
    }
}