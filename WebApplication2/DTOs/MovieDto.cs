using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyII.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
                
        [Required]
        public byte? GenreId { get; set; }
               
        [Required]
        public DateTime ReleaseDate { get; set; }
                
        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}