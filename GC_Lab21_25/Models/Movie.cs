using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GC_Lab21_25.Models
{
    public class Movie
    {

       
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage="Title can only be 50 characters max")]
        public string Title { get; set; }

        public string Genre { get; set; }
        
        [Required]
        [Range(typeof(DateTime), "1/1/1880", "12/31/2021", ErrorMessage = "Date must be between the year 1880 and 2021")]
        public DateTime Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }
    }
}
