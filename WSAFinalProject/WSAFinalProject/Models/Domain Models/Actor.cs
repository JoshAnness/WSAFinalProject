using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class Actor
    {
        public Actor() {
            Movies = new List<Movie>();
        }
        public string ActorId { get; set; }
        public string Name { get; set; }
        public string BirthYear { get; set; }
        public ICollection<Movie> Movies { get; set; }

        public ActorCast ActorCast { get; set; }
    }
}
