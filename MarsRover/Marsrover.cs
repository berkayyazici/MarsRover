using System;
using MarsRover.Controller;
using MarsRover.Models;
using MarsRover.Movements;

namespace MarsRover
{
    public class Marsrover
    {
        static void Main(string[] args)
        {
            MovingBackward movingBackward = new MovingBackward();
            MovingForward movingForward = new MovingForward();
            Directions directions = new Directions();
            CollusionController collusionController = new CollusionController();   
            Obstacles obstacles = new Obstacles();

            string devam = "Y";

            obstacles.GetObstacles();

            while (devam == "Y")
            {
                Console.Write("Give command to your rover : ");
                string command = Convert.ToString(Console.ReadLine()).ToLower();

                char[] commands = command.ToCharArray();

                for (int i = 0; i < commands.Length; i++)
                {
                    switch (commands[i])
                    {
                        case 'f':
                            movingForward.MovingF(Rover.direction);
                            collusionController.ForwardCollusionControl();
                            break;
                        case 'l':
                            directions.Direction(Rover.direction, commands[i].ToString());
                            break;

                        case 'r':
                            directions.Direction(Rover.direction, commands[i].ToString());
                            break;

                        case 'b':
                            movingBackward.MovingB(Rover.direction);
                            collusionController.BackwardCollusionControl();
                            break;

                        default:
                            Console.WriteLine("Movement stopped!");
                            break;
                    }
                }


                Console.WriteLine("Rover's X Coordinate : {0}, Y Coordinate : {1}, Direction : {2}",
                                    Rover.x_coordinate, Rover.y_coordinate, Rover.direction);

                Console.Write("Do you wanna continue ? : Yes => Y, No => N : ");
                devam = Convert.ToString(Console.ReadLine()).ToUpper();
            }

        }
    }
}
