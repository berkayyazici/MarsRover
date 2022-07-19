using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Obstacles
    {
        public int[,] obstacle = { { 1, 4 }, { 3, 5 }, { 7, 4 }, { 5, 2 } };

        public void GetObstacles()
        {
            int y = 0;

            for(int i = 0; i < obstacle.GetLength(0); i++)
            {
                Console.WriteLine("Obstacles - {0} : [{1},{2}]", (i + 1), obstacle[i, y], obstacle[i, y + 1]);
            }  
        }
    }
}
