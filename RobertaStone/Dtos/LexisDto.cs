using System;
using System.ComponentModel.DataAnnotations;
using RobertaStone.Models;

namespace RobertaStone.Dtos
{
    public class LexisDto
    {
        public int id { get; set; }
        public int LanguageId { get; set; }
        public int? ConversationPartnerId { get; set; }
        public int ContentTypeId { get; set; }
        public int LexisTypeId { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string LexisContent { get; set; }

       //[DateLearntNotInFuture]
        public DateTime DateLearnt { get; set; }

        public TimeSpan? TimeLearnt { get; set; }
    }
}