using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class Cast
    {
        public Cast()
        {
            Actors = new List<Actor>();
        }
        public int CastId { get; set; }

        public List<Actor> Actors { get; set; }

        public Movie Movie { get; set; }

        //public ActorCast ActorCast { get; set; }
    }
}
