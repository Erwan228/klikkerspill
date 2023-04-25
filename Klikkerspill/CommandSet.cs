using Klikkerspill.Commands;

namespace Klikkerspill
{
    public class CommandSet
    {
        private ICommand[] _commands;


        public CommandSet()
        {

            _commands = new ICommand[] { new SuperUpgrade(), new Exit(), new Click(), new Upgrade()};
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
    }
}
