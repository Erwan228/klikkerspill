namespace Klikkerspill
{
    public class Game
    {
        public int Points { get; set; }
        public int PointsPerClickIncrease { get; set; }
        public int PointsPerClick { get; set; }
        public CommandSet CommandSet { get; set; }

        public Game()
        {
            Points = 0;
            PointsPerClickIncrease = 1;
            PointsPerClick = 1;
            CommandSet = new CommandSet();
        }

        public void Play()
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng\r\n - X = avslutt applikasjonen");
            Console.WriteLine($"Du har {Points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
            var command = Console.ReadKey().KeyChar;
            if (command == 'X') Exit();
            else if (command == ' ') Click();
            else if (command == 'K' && Points >= 10) Upgrade();
            else if (command == 'S' && Points >= 100) SuperUpgrade();
        }
        public void Upgrade()
        {
        }
        public void Click()
        {
        }
        public void SuperUpgrade()
        {
        }
        public void Exit()
        {
        }
    }
}
