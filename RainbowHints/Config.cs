using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RainbowBroadcastPlugin
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("The message to display as a rainbow hint at the start of the round.")]
        public string BroadcastMessage { get; private set; } = "Good luck";

        [Description("The duration of the rainbow hint at the start of the round in seconds.")]
        public int BroadcastDuration { get; private set; } = 10;

        [Description("The colors to use for the rainbow hint at the start of the round.")]
        public string[] RoundStartColors { get; private set; } = { "red", "orange", "yellow", "green", "blue", "purple" };

        [Description("The message to display when a player escapes.")]
        public string EscapeMessage { get; private set; } = "You escaped!";

        [Description("The duration of the escape message in seconds.")]
        public int EscapeMessageDuration { get; private set; } = 10;

        [Description("The colors to use for the rainbow hint when a player escapes.")]
        public string[] EscapeColors { get; private set; } = { "blue", "red", "greem", "orange", "white", "yellow" };
    }
}
