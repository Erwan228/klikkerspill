namespace Klikkerspill.Commands
{
    public class Exit : ICommand
    {
        public char Command { get; } = 'X';

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
