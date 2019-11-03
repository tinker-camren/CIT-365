using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureJournal.Models
{
    public class Entry
    {
        public int ID { get; set; }
        [StringLength(40, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Book { get; set; }
        [Required]
        public int Chapter { get; set; }
        public int Verse { get; set; }
        [StringLength(2000)]
        [Required]
        public string Note { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateAdded { get; set; }

    }
}
