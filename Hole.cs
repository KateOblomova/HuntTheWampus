using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWampus
{
    public class Hole : NPC
    {
        public int _displayedAs = 4;
        public int[,] currentPosition;

        public override string NPCProperty()
        {
            return "You hear air move";
        }


    }
}
