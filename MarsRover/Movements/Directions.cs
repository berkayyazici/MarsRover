using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;
using MarsRover.Movements;

namespace MarsRover.Movements
{
    public class Directions
    {
        public void Direction(string direction, string command)
        {
            Rover.direction = direction;

            if(Rover.direction == "NORTH")
            {
                if(command == "l")
                {
                    Rover.direction = "WEST";
                }

                else if(command == "r")
                {
                    Rover.direction = "EAST";
                }
            }

            else if (Rover.direction == "SOUTH")
            {
                if (command == "l")
                {
                    Rover.direction = "EAST";
                }

                else if( command == "r")
                {
                    Rover.direction = "WEST";
                }
            }

            else if (Rover.direction == "EAST")
            {
                if (command == "l")
                {
                    Rover.direction = "NORTH";
                }

                else if (command == "r")
                {
                    Rover.direction = "SOUTH";
                }
            }

            else
            {
                if (command == "l")
                {
                    Rover.direction = "SOUTH";
                }

                else if (command == "r")
                {
                    Rover.direction = "NORTH";
                }
            }
        }
    }
}
