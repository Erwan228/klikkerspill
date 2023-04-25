namespace Klikkerspill.Commands
{
    public class SuperUpgrade : ICommand
    {
        public char Command { get; } = 'S';

        public void Run()
        {
            Points -= 100;
            PointsPerClickIncrease++;
        }
    }
}
