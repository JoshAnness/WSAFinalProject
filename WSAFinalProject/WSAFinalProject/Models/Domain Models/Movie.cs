using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WSAFinalProject.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1888, 3000, ErrorMessage = "Year must be after 1888.")]
        public int? Year { get; set; }
        public string GenreId { get; set; }
        public Genre Genre { get; set; }

        public int Duration { get; set; }

        public string DescriptionId { get; set; }
        public Description Description { get; set; }

        public string CastId { get; set; }
        public Cast Cast { get; set; }
    }
}

