namespace Klikkerspill.Commands
{
    public class Upgrade : ICommand
    {
        public char Command { get; } = 'K';

        public Game _game { get; }

        public Upgrade(Game game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.Points -= 10;
            _game.PointsPerClick += _game.PointsPerClickIncrease;

        }
    }
}
