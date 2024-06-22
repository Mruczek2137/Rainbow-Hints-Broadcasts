# RainbowBroadcast Plugin for SCP: Secret Laboratory (EXILED 8.9.6)

## Overview

RainbowBroadcast is a simple plugin for SCP: Secret Laboratory servers running EXILED that allows server administrators to display a rainbow-colored broadcast message to all players at the start of each round. The color of the message changes dynamically, creating a visually appealing effect.

### Features

- Displays a customizable rainbow broadcast message at the start of each round.
- Configurable duration and text of the broadcast.
- Uses colors that change dynamically over time.

## Installation

1. Download the latest release from the [Releases](https://github.com/Mruczek2137/RainbowBroadcast/releases) page.
2. Place the `RainbowBroadcast.dll` file into your `Plugins` folder.

## Configuration

The plugin can be configured via the `config.yml` file located in your `Plugins` folder. Here are the available options:

- `IsEnabled`: Enables or disables the plugin (default: `true`).
- `DefaultBroadcastDuration`: Duration of the broadcast in seconds at the start of each round (default: `10` seconds).
- `DefaultBroadcastMessage`: Default message displayed in the broadcast (default: `"Good luck!"`).

Example `config.yml`:

```yaml
RainbowBroadcast:
  IsEnabled: true
  DefaultBroadcastDuration: 10
  DefaultBroadcastMessage: "Good Luck!"
