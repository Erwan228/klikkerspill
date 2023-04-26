namespace Klikkerspill.Commands
{
    public class Click : ICommand
    {
        public char Command { get; } = ' ';

        public Game Game { get; }

        public Click(Game game)
        {
            Game = game;
        }

        public void Run()
        {
            Game.Points += Game.PointsPerClick;
        }

        public string ShowDescription()
        {
            return "SPACE - Du får poeng";
        }
    }
}
