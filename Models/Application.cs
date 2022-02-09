using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace mission4.Models
{
    public class Application
    {
        //Desired inputs for movies

        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required]
        public string Title { get; set; }

        
        [Range(1888, 2100)]
        public ushort Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        [Range(0, 25)]
        public string Notes { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
