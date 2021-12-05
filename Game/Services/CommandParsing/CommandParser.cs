using System;
using System.Collections.Generic;

namespace Game.Services.CommandParsing
{
    public class CommandParser : ICommandParser
    {
        private readonly Dictionary<string, ConsoleCommand> _keywords = new()
        {
            { "help", ConsoleCommand.Help },
            { "new", ConsoleCommand.StartMatch },
            { "join", ConsoleCommand.JoinMatch }
        };

        public ConsoleCommand ParseCommand(string commandString)
        {
            string[] tokens = commandString.Split(" ");
            var command = _keywords[tokens[0].ToLower()];

            ValidateCommand(tokens, command);

            return command;
        }

        private static void ValidateCommand(string[] tokens, ConsoleCommand command)
        {
            switch (command)
            {
                case ConsoleCommand.Help:
                    break;
                case ConsoleCommand.StartMatch:
                    if (tokens.Length != 2) throw new Exception();
                    break;
                case ConsoleCommand.JoinMatch:
                    if (tokens.Length != 3) throw new Exception();
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
