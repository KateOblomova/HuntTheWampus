using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWampus
{
    public class Wumpus : NPC
    {
        public int _displayedAs = 2;
        public int[,] currentPosition { get; set; }
        public virtual void CurrentPositionDeclare()
        {
            currentPosition = PositionRandomChange();
        }
        public override string NPCProperty()
        {
            return "It stinks";
        }
    }
}
