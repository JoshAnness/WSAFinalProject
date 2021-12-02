using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WSAFinalProject.Models
{
    public class Description
    {
        public int DescriptionId { get; set; }

        public string DescriptionText { get; set; }

        public Movie Movie { get; set; }

    }
}
