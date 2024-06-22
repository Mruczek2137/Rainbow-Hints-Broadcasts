using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RainbowBroadcastPlugin
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("The message to display as a rainbow broadcast.")]
        public string BroadcastMessage { get; private set; } = "Good luck";

        [Description("The duration of the rainbow broadcast in seconds.")]
        public int BroadcastDuration { get; private set; } = 10;
    }
}
