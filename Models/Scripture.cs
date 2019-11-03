using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public string Book { get; set; }
        [Display(Name = "Scripture Passage")]
        public string ScripturePassage { get; set; }
        public string Note { get; set; }   
    }
}
