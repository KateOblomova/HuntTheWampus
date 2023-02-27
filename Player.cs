using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HuntTheWampus.Move;

namespace HuntTheWampus
{
    public class Player : NPC
    {
        public int _displayedAs = 1;
        public int[,] currentPosition { get; set; }

        public override void CurrentPositionDeclare()
        {
            currentPosition = PositionRandomChange();
        }

        PlayingField field = new PlayingField();
        public override string NPCProperty()
        {
            return "";
        }
        public void MoveIt()
        {
            var choosenButton = Console.ReadKey().Key;
            bool isTrue = true;

            do
            {
                switch (choosenButton)
                {
                    case ConsoleKey.UpArrow:
                        for(int i = 0; i<= currentPosition.GetLength(0); i++)
                        {
                            for(int j = 0; j<= currentPosition.GetLength(1); j++)
                            {
                                if (currentPosition[i, j] == _displayedAs)
                                {

                                }
                            }
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        break;
                    case ConsoleKey.LeftArrow:

                        break;
                    case ConsoleKey.RightArrow:

                        break;
                    default:
                        isTrue = false;
                        break;
                }
            } while (isTrue);
        }
    }
}
