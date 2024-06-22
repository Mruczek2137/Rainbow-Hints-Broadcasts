using Exiled.API.Features;
using System;

namespace RainbowBroadcastPlugin
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "RainbowBroadcast";
        public override string Author => "mruczek :3";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 9, 6);

        public static Plugin Instance { get; private set; }

        private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Server.RoundStarted += eventHandlers.OnRoundStarted;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= eventHandlers.OnRoundStarted;
            eventHandlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}
