using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? Book { get; set; } = string.Empty;
        [Range(1, 200)]
        public int Chapter { get; set; }
        [Range(1, 200)]
        public int Verse { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        [StringLength(2048)]
        public string? Entry { get; set; }
    }
}
