using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class ActorCast
    {
        public int ActorId { get; set; }
        public int CastId { get; set; }

        public ICollection<Actor> Actors { get; set; }
        public ICollection<Cast> Casts { get; set; }

    }
}
