using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        [Display(Name = "Note Id")]
        public int NoteId { get; set; }
        [Required]
        [Display(Name = "Owner Id")]
        public Guid OwnerId { get; set; }
        [Required]
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Content")]
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field.")]
        public string Content { get; set; }
        [DefaultValue(false)]
        public bool IsStarred { get; set; }
        [Required]
        [Display(Name = "Time Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Time Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
