using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWampus
{
    public class PlayingField
    {
        public int currentPosition;
        public int[,] field = new int[5, 5];
        

        //public PlayingField(int[,] field)
        //{
        //    this.field = field;
        //}

        public int[,] DrawAField()
        {

            for (int i = 0; i <= field.GetLength(0); i++)
            {
                for (int j = 0; j <= field.GetLength(1); j++)
                {
                    field[i, j] = 0;
                    Console.WriteLine("{0}\t", field[i, j]);
                }
            }
            return field;
        }
    }
}
