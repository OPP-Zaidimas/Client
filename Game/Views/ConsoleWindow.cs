using System;
using System.Windows.Forms;
using Game.Services.CommandParsing;
using Game.Services.SignalR;

namespace Game.Views
{
    public partial class ConsoleWindow : Form
    {
        private int _currentCommand = 0;

        private string[] _lastCommand;

        private readonly SignalRService _service;
        private readonly ICommandParser _parser;

        public ConsoleWindow(SignalRService service, ICommandParser parser)
        {
            InitializeComponent();

            _service = service;
            _service.Connect();
            _service.MatchIdReceived += OnMatchIdReceived;
            _service.CloseMatchWindow += OnCloseReceived;

           _parser = parser;

            ConsoleHistoryLabel.Text = "";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            RegisterCommand();
        }

        private void CommandTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterCommand();
            }
        }

        private void RegisterCommand()
        {
            string command = CommandTextBox.Text;
            _lastCommand = command.Split(" ");

            ConsoleHistoryLabel.Text += $"[ {++_currentCommand,3} ]  {command}\n";
            CommandTextBox.Text = string.Empty;

            ParseCommand(command);
        }

        private void ParseCommand(string commandString)
        {
            try
            {
                var command = _parser.ParseCommand(commandString);
                HandleCommand(command);
            }
            catch (Exception)
            {
                ConsoleHistoryLabel.Text += "Invalid command!\n";
            }
        }

        private async void HandleCommand(ConsoleCommand command)
        {
            switch (command)
            {
                case ConsoleCommand.Help:
                    PrintHelp();
                    break;
                case ConsoleCommand.StartMatch:
                    await _service.CreateNewGame(_lastCommand[1]);
                    break;
                case ConsoleCommand.JoinMatch:
                    int matchId = int.Parse(_lastCommand[1]);
                    string username = _lastCommand[2];

                    await _service.JoinGame(matchId, username);
                    break;
                default:
                    ConsoleHistoryLabel.Text += "Invalid command!\n";
                    break;
            }
        }

        private void PrintHelp()
        {
            ConsoleHistoryLabel.Text += "\"Help\" => prints help\n";
            ConsoleHistoryLabel.Text += "\"New <username>\" => starts a new match\n";
            ConsoleHistoryLabel.Text += "\"Join <id> <username>\" => tries to join a match with a specified ID\n";
        }

        private void OnMatchIdReceived(int matchId)
        {
            ConsoleHistoryLabel.Text += $"Match ID: {matchId}\n";
        }

        private void OnCloseReceived()
        {
            Close();
        }
    }
}
