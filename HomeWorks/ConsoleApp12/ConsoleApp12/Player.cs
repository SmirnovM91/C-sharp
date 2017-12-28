using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Player
    {
        public static int playerCount = 0;
        public string Name { get; set; }
        public List<Karta> Cards { get; set; }
        public Player()
        {
            playerCount++;
            Name = "Player #" + playerCount;
            Cards = new List<Karta>();
        }
    }
}
