using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System.Collections;
using System.Collections.Generic;

namespace RainbowBroadcastPlugin
{
    public class EventHandlers
    {
        private readonly string[] colors = { "red", "orange", "yellow", "green", "blue", "aqua", "purple", "teal" };

        public void OnRoundStarted()
        {
            Timing.RunCoroutine(SendRainbowBroadcast(Plugin.Instance.Config.BroadcastMessage, Plugin.Instance.Config.BroadcastDuration));
        }

        public IEnumerator<float> SendRainbowBroadcast(string message, int duration)
        {
            for (int i = 0; i < duration * 2; i++) // Changing color every 0.5 seconds
            {
                string currentColor = colors[i % colors.Length];
                string rainbowMessage = $"<color={currentColor}>{message}</color>";
                Map.Broadcast(1, rainbowMessage);
                yield return Timing.WaitForSeconds(0.5f);
            }
        }
    }
}
