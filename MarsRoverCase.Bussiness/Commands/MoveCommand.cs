using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Bussiness.Command
{
    public class MoveCommand : Command
    {
        public MoveCommand(Direction direction) : base(direction)
        { }

        public override string Execute()
        {
            switch (direction.Dir)
            {
                case "N":
                    if (direction.Y < direction.RowMax)
                        direction.Y++;
                    break;
                case "W":
                    if (direction.X > 0)
                        direction.X--;
                    break;
                case "S":
                    if (direction.Y > 0)
                        direction.Y--;
                    break;
                case "E":
                    if (direction.X < direction.ColMax)
                        direction.X++;
                    break;
                default:
                    throw new ArgumentException();
            }

            return "";
        }
    }
}
