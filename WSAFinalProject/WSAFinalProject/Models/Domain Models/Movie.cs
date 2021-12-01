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
        
        [Required(ErrorMessage = "Please select a genre.")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required(ErrorMessage ="Please enter a duration in minutes.")]
        [Range(1,400,ErrorMessage = "Duration must be between 1 and 400 minutes.")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public int DescriptionId { get; set; }
        public Description Description { get; set; }

        public int CastId { get; set; }
        public Cast Cast { get; set; }
    }
}

