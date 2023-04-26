using Klikkerspill.Commands;

namespace Klikkerspill
{
    public class CommandSet
    {
        private ICommand[] _commands;

        private Game _game;


        public CommandSet(Game game)
        {
            _game = game;

            _commands = new ICommand[] { new SuperUpgrade(game), new Exit(), new Click(game), new Upgrade(game)};
        }

        public void RunCommand(char character)
        {
            foreach(var command in _commands)
            {
                if(command.Command == character)
                {
                    command.Run();
                }
            }
        }
        
        public void ShowCommandDescriptions()
        {
            foreach(var command in _commands)
            {
                Console.WriteLine(command.ShowDescription());
            }
        }
    }
}
