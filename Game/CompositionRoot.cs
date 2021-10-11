using Game.Models.Hero;
using Game.Services;
using Game.Views.User_Controls;

namespace Game
{
    public class CompositionRoot
    {
        private readonly SignalRService _service;
        private readonly IFactory<IHero> _heroFactory;

        public GameWindow MainForm
        {
            get
            {
                var gameWindow = new GameWindow();
                var mainMenu = new MainMenu(_service, _heroFactory, gameWindow);
                gameWindow.SetContent(mainMenu);

                return gameWindow;
            }
        }

        public CompositionRoot(SignalRService service, IFactory<IHero> heroFactory)
        {
            _service = service;
            _heroFactory = heroFactory;
        }
    }
}
