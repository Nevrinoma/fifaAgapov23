using System.Collections.Generic;
using fifaAgapov23.Models;

namespace fifaAgapov23.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Player> Players { get; set; }
    }
}
