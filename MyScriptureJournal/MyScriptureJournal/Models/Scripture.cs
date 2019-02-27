using System;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Set { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public string Notes { get; set; }

    }
    public class Books
    {
        public int ID { get; set; }
        public string Set { get; set; }
        public string Book { get; set; }
    }
}
