using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWampus
{
    public class Bat : NPC
    {
        public int _displayedAs = 3;
        public int[,] currentPosition { get; set; }

        public override void CurrentPositionDeclare()
        {
            currentPosition = PositionRandomChange();
        }
        public override string NPCProperty()
        {
            return "You hear rustle";
        }

        //PlayingField field = new PlayingField();
        //public override void PositionRandomChange()
        //{
        //    Random ranI = new Random();
        //    Random ranJ = new Random();
        //    var newI = ranI.Next(0, 5);
        //    var newJ = ranJ.Next(0, 5);

        //    int[,] currentField = field.DrawAField();

        //    for(int i = 0; i < currentField.GetLength(0); i++)
        //    {
        //        for(int j = 0; j < currentField.GetLength(1); j++)
        //        {
        //            if(newI == i && newJ == j)
        //            {
        //                currentField[i, j] = _displayedAs;
        //            }
        //        }
        //    }
        //}        
    }
}
