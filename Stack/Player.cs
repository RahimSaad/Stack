using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack
{
    class Player
    {
        public String name { get; }
        public int score { get; }
        public Player(string name, int score)
        {
            this.name = name;
            this.score = score; 
        }
    }
}
