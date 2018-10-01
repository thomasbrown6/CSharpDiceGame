using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsGame
{
    public class Player
    {
        public int player_id { get; set; }
        
        public string name { get; set; }

        public string email { get; set; }

        // Reads the properties above
        public string fullInfo
        {
            get
            {
                // Returns "Thomas" name for player
                return $"{ name } { email }";
            }
        }

    }
}
