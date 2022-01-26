using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission4.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }

        [Range(typeof(DateTime), "1/1/1900", "1/1/2100",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public ushort Year { get; set; }

        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }

        [Range(1,25)]
        public string Notes { get; set; }

    }
}
