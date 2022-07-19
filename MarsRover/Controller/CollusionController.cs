using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Models;
using MarsRover.Movements;

namespace MarsRover.Controller
{
    public class CollusionController
    {
        Obstacles obstacles = new Obstacles();

        public void ForwardCollusionControl()
        {
            int z = 0; // rows
            int y = 1; // columns


            for (int i = 0; i < obstacles.obstacle.GetLength(0); i++)
            {
                if (Rover.x_coordinate == obstacles.obstacle[i, z] && Rover.y_coordinate == obstacles.obstacle[i, y])
                {
                    //Rover.y_coordinate = (Rover.direction == "NORTH") ? Rover.y_coordinate += 1 : Rover.y_coordinate -= 1;
                    //Rover.y_coordinate = (Rover.direction == "SOUTH") ? Rover.y_coordinate -= 1 : Rover.y_coordinate += 1;
                    //Rover.x_coordinate = (Rover.direction == "WEST") ? Rover.x_coordinate -= 1 : Rover.x_coordinate += 1;
                    //Rover.x_coordinate = (Rover.direction == "EAST") ? Rover.y_coordinate += 1 : Rover.y_coordinate -= 1;

                    if (Rover.direction == "NORTH")
                    {
                        Rover.y_coordinate -= 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }

                    else if (Rover.direction == "SOUTH")
                    {
                        Rover.y_coordinate += 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }

                    else if (Rover.direction == "EAST")
                    {
                        Rover.x_coordinate -= 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }

                    else
                    {
                        Rover.x_coordinate += 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }
                }

            }

        }

        public void BackwardCollusionControl()
        {
            int z = 0; // rows
            int y = 1; // columns

            for (int i = 0; i < obstacles.obstacle.GetLength(0); i++)
            {
                if (Rover.x_coordinate == obstacles.obstacle[i, z] && Rover.y_coordinate == obstacles.obstacle[i, y])
                {
                    //Rover.y_coordinate = (Rover.direction == "NORTH") ? Rover.y_coordinate -= 1 : Rover.y_coordinate += 1;
                    //Rover.y_coordinate = (Rover.direction == "SOUTH") ? Rover.y_coordinate += 1 : Rover.y_coordinate -= 1;
                    //Rover.x_coordinate = (Rover.direction == "WEST") ? Rover.x_coordinate += 1 : Rover.x_coordinate -= 1;
                    //Rover.x_coordinate = (Rover.direction == "EAST") ? Rover.x_coordinate -= 1 : Rover.x_coordinate += 1;

                    if (Rover.direction == "NORTH")
                    {
                        Rover.y_coordinate += 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }

                    else if (Rover.direction == "SOUTH")
                    {
                        Rover.y_coordinate -= 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }

                    else if (Rover.direction == "EAST")
                    {
                        Rover.x_coordinate += 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }

                    else
                    {
                        Rover.x_coordinate -= 1;
                        Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}, STOPPED !",
                        Rover.x_coordinate, Rover.y_coordinate, Rover.direction);
                        break;
                    }

                }

            }

        }
    }
}
