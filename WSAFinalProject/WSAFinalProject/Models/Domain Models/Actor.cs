using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class Actor
    {
        public Actor() {
            ActorMovies = new List<ActorMovie>();
        }
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string BirthYear { get; set; }
        public ICollection<ActorMovie> ActorMovies { get; set; }

        //public ActorCast ActorCast { get; set; }
    }
}
