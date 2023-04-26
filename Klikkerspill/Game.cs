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
            CommandSet = new CommandSet(this);
        }

        public void Play()
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:");
            CommandSet.ShowCommandDescriptions();
            Console.WriteLine($"Du har {Points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
            var command = Console.ReadKey().KeyChar;
            CommandSet.RunCommand(command);
        }
    }
}
