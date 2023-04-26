namespace Klikkerspill.Commands
{
    public class Upgrade : ICommand
    {
        public char Command { get; } = 'K';

        public Game Game { get; }

        public Upgrade(Game game)
        {
            Game = game;
        }

        public void Run()
        {
            if (Game.Points >= 10)
            {
                Game.Points -= 10;
                Game.PointsPerClick += Game.PointsPerClickIncrease;
            }
        }

        public string ShowDescription()
        {
            return "K - Du kjøper en vanlig upgrade";
        }
    }
}
