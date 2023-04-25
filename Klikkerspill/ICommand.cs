namespace Klikkerspill
{
    internal interface ICommand
    {
        char Command { get; }
        void Run();
    }
}
