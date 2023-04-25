namespace Klikkerspill.Commands
{
    public class Upgrade : ICommand
    {
        public char Command { get; } = 'K';

        public void Run()
        {
            Points -= 10;
            PointsPerClick += PointsPerClickIncrease;
        }
    }
}
