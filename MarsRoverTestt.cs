using System;
using Xunit;
using MarsRover;
using MarsRover.Controller;
using MarsRover.Models;
using MarsRover.Movements;
using System.Collections.Generic;
using System.Collections;

namespace MarsRoverTest
{

    public class BackwardVerticalTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "NORTH", 0, -1 };
            yield return new object[] { "NORTH", 4, 3 };
            yield return new object[] { "SOUTH", 1, 2 };
            yield return new object[] { "SOUTH", 2, 3 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class MarsRoverTestt
    {
        [Theory]
        [MemberData(nameof(DirectionTestData))]
        public void Turning_From_CurrentDirection_Test(string command, string RoverDirection, string expected)
        {
            var obj = new Directions();
            obj.Direction(RoverDirection, command);
            Assert.Equal(expected, Rover.direction);
        }

       
        public static IEnumerable<object[]> DirectionTestData =>
        new List<object[]>
        {
            new object[] { "l", "NORTH", "WEST" },
            new object[] { "l", "SOUTH", "EAST" },
            new object[] { "l", "WEST", "SOUTH" },
            new object[] { "l", "EAST", "NORTH" },
            new object[] { "r", "NORTH", "EAST" },
            new object[] { "r", "SOUTH", "WEST" },
            new object[] { "r", "WEST", "NORTH" },
            new object[] { "r", "EAST", "SOUTH" }
        };

        [Theory]
        [InlineData("NORTH", 0, 1)]
        [InlineData("NORTH", 4, 5)]
        [InlineData("SOUTH", 1, 0)]
        [InlineData("SOUTH", 2, 1)]
        public void Is_Rover_MovingForward_on_Vertical_Test(string direction, int coordinate, int expected)
        {
            Rover.y_coordinate = coordinate;
            var obj = new MovingForward();
            obj.MovingF(direction);
            Assert.Equal(expected, Rover.y_coordinate);
        }

        [Theory]
        [InlineData("EAST", 2, 3)]
        [InlineData("EAST", 6, 7)]
        [InlineData("WEST", 5, 4)]
        [InlineData("WEST", 1, 0)]
        public void Is_Rover_MovingForward_on_Horizontal_Test(string direction, int coordinate, int expected)
        {
            Rover.x_coordinate = coordinate;
            var obj = new MovingForward();
            obj.MovingF(direction);
            Assert.Equal(expected, Rover.x_coordinate);
        }


        [Theory]
        [ClassData(typeof(BackwardVerticalTestData))]
        public void Is_Rover_MovingBackward_on_Vertical_Test(string direction, int coordinate, int expected)
        {
            Rover.y_coordinate = coordinate;
            var obj = new MovingBackward();
            obj.MovingB(direction);
            Assert.Equal(expected, Rover.y_coordinate);
        }

        [Theory]
        [MemberData(nameof(Data_Horizontal))]
        public void Is_Rover_MovingBackward_on_Horizontal_Test(string direction, int coordinate, int expected)
        {
            Rover.x_coordinate = coordinate;
            var obj = new MovingBackward();
            obj.MovingB(direction);
            Assert.Equal(expected, Rover.x_coordinate);
        }

        public static IEnumerable<object[]> Data_Horizontal =>
        new List<object[]>
        {
            new object[] { "EAST", 8, 7 },
            new object[] { "EAST", 9, 8 },
            new object[] { "WEST", 0, 1 },
            new object[] { "WEST", 6, 7 },
        };

    }
}