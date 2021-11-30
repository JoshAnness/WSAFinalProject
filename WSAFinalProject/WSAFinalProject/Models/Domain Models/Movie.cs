using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WSAFinalProject.Models
{
    public class Movie
    {
        public string MovieId { get; set; }

        public string Name { get; set; }

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

