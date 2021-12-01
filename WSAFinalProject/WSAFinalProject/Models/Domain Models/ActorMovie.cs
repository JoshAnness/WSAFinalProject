using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class ActorMovie
    { 
        public int ActorId { get; set; }
        public int MovieId { get; set; }

        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
