namespace Klikkerspill.Commands
{
    public class Click : ICommand
    {
        public char Command { get; } = ' ';

        public void Run()
        {
            Points += PointsPerClick;
        }
    }
}
