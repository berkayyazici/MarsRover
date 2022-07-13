using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;
using MarsRover.Movements;

namespace MarsRover.Controller
{
    internal class CollusionController
    {
        Obstacles obstacles = new Obstacles();

        public void CollusionControl()
        {
            int z = 0; // rows
            int y = 1; // columns

            for (int i = 0; i < obstacles.obstacle.GetLength(0); i++)
            {
                if (Rover.x_coordinate == obstacles.obstacle[i, z])
                {
                    if (Rover.y_coordinate == obstacles.obstacle[i, y])
                    {
                        Rover.y_coordinate -= 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }

                }

            }

        }
    }
}
