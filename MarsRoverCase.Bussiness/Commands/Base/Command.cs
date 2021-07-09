namespace MarsRoverCase.Bussiness.Command
{
    public abstract class Command : ICommand
    {
        protected readonly Direction direction;

        public Command(Direction direction)
        {
            this.direction = direction;
        }
        public abstract string Execute();

    }
}
