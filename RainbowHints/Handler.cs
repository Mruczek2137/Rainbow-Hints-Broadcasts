using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using MEC;
using System.Collections;
using System.Collections.Generic;

namespace RainbowBroadcastPlugin
{
    public class EventHandlers
    {
        public void OnRoundStarted()
        {
            Timing.RunCoroutine(SendRainbowHint(Plugin.Instance.Config.BroadcastMessage, Plugin.Instance.Config.BroadcastDuration, Plugin.Instance.Config.RoundStartColors));
        }

        public void OnPlayerEscaped(EscapingEventArgs ev)
        {
            Timing.RunCoroutine(SendRainbowHint(ev.Player, Plugin.Instance.Config.EscapeMessage, Plugin.Instance.Config.EscapeMessageDuration, Plugin.Instance.Config.EscapeColors));
        }

        public IEnumerator<float> SendRainbowHint(string message, int duration, string[] colors)
        {
            for (int i = 0; i < duration * 2; i++) // Changing color every 0.5 seconds
            {
                string currentColor = colors[i % colors.Length];
                string rainbowMessage = $"<color={currentColor}>{message}</color>";
                foreach (Player player in Player.List)
                {
                    player.ShowHint(rainbowMessage, 1); // Show hint for 1 second
                }
                yield return Timing.WaitForSeconds(0.5f);
            }
        }

        public IEnumerator<float> SendRainbowHint(Player player, string message, int duration, string[] colors)
        {
            for (int i = 0; i < duration * 2; i++) // Changing color every 0.5 seconds
            {
                string currentColor = colors[i % colors.Length];
                string rainbowMessage = $"<color={currentColor}>{message}</color>";
                player.ShowHint(rainbowMessage, 1); // Show hint for 1 second
                yield return Timing.WaitForSeconds(0.5f);
            }
        }
    }
}
