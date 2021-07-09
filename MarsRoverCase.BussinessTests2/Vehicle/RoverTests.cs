using Microsoft.VisualStudio.TestTools.UnitTesting;

using FluentAssertions;

using NUnit.Framework;
using MarsRoverCase.Bussiness.Command;

namespace MarsRoverCase.Bussiness.Vehicle.Tests
{
    [TestClass()]
    public class RoverTests
    {
        [TestMethod()]
        [TestCase(1, 3)]
        public void When_Given_Then_It_Should_LeftCommand_Execute(int x,int y)
        {
            Direction direction = new Direction();
            direction.X = x;
            direction.Y = y;

            ICommand command = new TurnLeftCommand(direction);
            var result = command.Execute();
            result.Should().NotBeNull();
        }

        [TestMethod()]
        [TestCase(1, 3)]
        public void When_Given_Then_It_Should_RightCommand_Execute(int x, int y)
        {
            Direction direction = new Direction();
            direction.X = x;
            direction.Y = y;

            ICommand command = new TurnRightCommand(direction);
            var result = command.Execute();
            result.Should().NotBeNull();
        }

        [TestMethod()]
        [TestCase(1, 3)]
        public void When_Given_Then_It_Should_MoveCommand_Execute(int x, int y)
        {
            Direction direction = new Direction();
            direction.X = x;
            direction.Y = y;

            ICommand command = new MoveCommand(direction);
            var result = command.Execute();
            result.Should().NotBeNull();
        }
    }
}