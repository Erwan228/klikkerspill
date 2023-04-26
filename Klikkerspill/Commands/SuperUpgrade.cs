namespace Klikkerspill.Commands
{
    public class SuperUpgrade : ICommand
    {
        public char Command { get; } = 'S';

        public Game Game { get; }


        public SuperUpgrade(Game game)
        {
            Game = game;
        }

        public void Run()
        {
            if (Game.Points >= 100)
            {
                Game.Points -= 100;
                Game.PointsPerClickIncrease++;
            }
        }

        public string ShowDescription()
        {
            return "S - Du kjøper en superupgrade";
        }
    }
}
