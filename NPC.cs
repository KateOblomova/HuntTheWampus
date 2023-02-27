using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWampus
{
    public abstract class NPC
    {
        public int _displayedAs;
        public int[,] currentPosition { get; set; }
        public abstract string NPCProperty();
        public virtual void CurrentPositionDeclare()
        {
            currentPosition = PositionRandomChange();
        }
        public enum PossibleMovements
        {
            up, down, right, left
        }
        PlayingField field = new PlayingField();
        //public virtual void MoveIt() { }
        public int[,] PositionRandomChange()
        {
            Random ranI = new Random();
            Random ranJ = new Random();
            var newI = ranI.Next(0, 5);
            var newJ = ranJ.Next(0, 5);

            int[,] currentField = field.DrawAField();

            for (int i = 0; i < currentField.GetLength(0); i++)
            {
                for (int j = 0; j < currentField.GetLength(1); j++)
                {
                    if (newI == i && newJ == j)
                    {
                        currentField[i, j] = _displayedAs;
                    }
                }
            }
            return currentField;
        }
    }
}
