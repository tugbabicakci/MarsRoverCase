using System;

namespace MarsRoverCase.Bussiness.Command
{
    public class TurnLeftCommand : Command
    {
        public TurnLeftCommand(Direction direction) : base(direction)
        { }

        public override string Execute()
        {
            int index = Array.IndexOf(direction.Str_dir, direction.Dir);
            if (index > -1 && index < direction.Str_dir.Length)
            {
                direction.Dir = direction.Str_dir[(index - 1 + direction.Str_dir.Length) % direction.Str_dir.Length];
            }
            else
            {
                 throw new ArgumentException();  
            }
            return direction.Dir;
        }

    }
}
