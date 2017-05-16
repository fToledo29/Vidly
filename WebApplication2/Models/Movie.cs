using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyII.Models
{
    public class Movie
    {
        public Movie()
        {
            DateTime defaultDate = new DateTime();
            ReleaseDate = defaultDate;
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Date of added")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Release date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}