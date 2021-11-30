using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class ActorCast
    {
        public string ActorId { get; set; }
        public string CastId { get; set; }

        public ICollection<Actor> Actors { get; set; }
        public ICollection<Cast> Casts { get; set; }

    }
}
