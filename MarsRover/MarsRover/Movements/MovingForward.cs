using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Controller;
using MarsRover.Models;
using MarsRover.Movements;

namespace MarsRover.Movements
{
    internal class MovingForward
    {
        public void MovingF(string direction)
        {
            switch (direction)
            {
                case "EAST":
                    Rover.x_coordinate += 1;
                    break;

                case "NORTH":
                    Rover.y_coordinate += 1;
                    break;

                case "SOUTH":
                    Rover.y_coordinate -= 1;
                    break;

                case "WEST":
                    Rover.x_coordinate -= 1;
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;

            }
        }
    }
}
