# MarsRover

A rover that explores Mars by sending remotely controlled vehicles to the surface of the planet. I developed a console app that translates the commands sent from 
earth to instructions that are understood by the rover.

The rover is given a command string which contains multiple commands. This string must then be broken into each individual command and that command then executed. 
The valid commands are;

-"F" : Move forward on current heading (direction) 

-"B" : Move backwards on current heading 

-"L" : Rotate left by 90 degrees

-"R" : Rotate right by 90 degrees

There is no "Edge of the world" to fall off, so negative coordinates are valid.

There are also some obstacles that caused damage to the rover. You can find their coordinates in Obstacles.cs. If you want to add more obstacle, just add some coordinates
into obstacle array. If you try to move your rover into any obstacle, rover won't move and will say it is stopped (It keeps its coordinates and heading before crash into 
obstacle.).
