namespace Game.Services.SignalR
{
    public static class NetworkCall
    {
        public const string ReceiveCode = "ReceiveCode";
        public const string ReceiveFailure = "ReceiveFailure";
        public const string StartGame = "StartGame";

        public const string CreateGame = "CreateNewGame";
        public const string JoinGame = "JoinGame";
        public const string PlaceCard = "PlaceCard";
        public const string ReceiveCardDecks = "ReceiveCardDecks";
        public const string ReceiveEndTurn = "ReceiveEndTurn";
        public const string MonsterAttack = "MonsterAttack";
        public const string ReceiveHPs = "ReceiveHPs";
        public const string ReceiveHeroHPs = "ReceiveHeroHPs";

        public const string AttackOnHero = "AttackOnHero";

        public const string EndTurn = "EndTurn";

        public const string ReceivePlayerState = "ReceivePlayerState";

    }
}
