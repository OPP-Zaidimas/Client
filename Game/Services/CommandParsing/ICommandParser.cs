namespace Game.Services.CommandParsing
{
    public interface ICommandParser
    {
        public ConsoleCommand ParseCommand(string command);
    }
}
