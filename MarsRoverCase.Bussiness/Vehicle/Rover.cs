using MarsRoverCase.Bussiness.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Bussiness.Vehicle
{
    public class Rover : IRover
    {
        public Direction direction;

        public Rover(Direction direction)
        {
            this.direction = direction;
            string[] str = direction.Location.Split(' ');
            this.direction.X = Int32.Parse(str[0]);
            this.direction.Y = Int32.Parse(str[1]);
            this.direction.Dir = str[2];
            this.direction.RowMax = direction.RowMax;
            this.direction.ColMax = direction.ColMax;
        }

        public string Operation(string strMessages)
        {
            char[] messages = strMessages.ToCharArray();
            var result = "";
            for (int i = 0; i < messages.Length; i++)
            {
                Command.Command cmd = null;
                switch (messages[i])
                {
                    case 'L':
                        cmd = new TurnRightCommand(direction);
                        break;
                    case 'R':
                        cmd = new TurnLeftCommand(direction);
                        break;
                    case 'M':
                        cmd = new MoveCommand(direction);
                        break;
                    default:
                        new ArgumentException($"Invalid command parameter");
                        break;
                }
                result = cmd.Execute();
            }
            return result;
        }
    }
}
