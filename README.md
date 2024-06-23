# 🌈 **RainbowHints**

**RainbowHints** is a plugin for the [Exiled](https://github.com/galaxy119/EXILED) framework that adds colorful hints to enrich the experience on your server.

## Features
- **Dynamic Rainbow Hints:** Display dynamic, eye-catching messages using a variety of colors.
- **Customizable Settings:** Tailor messages, display durations, and color sequences to fit your server's style.
- **Easy Integration:** Simple configuration allows for quick setup of the plugin.

## Installation
1. **Download** the latest release from the [releases page](https://github.com/Mruczek2137/Rainbow-Hints-Broadcasts/releases).
2. **Place** the DLL file into your Exiled `Plugins` folder.
3. **Customize** settings in the `config.yml` under the `RainbowHints` section.

## Version History
- **1.1.0 (Current):** Added support for hints, expanded functionality.
- **1.0.0:** Initial release of RainbowHints plugin.

## Issues
If you encounter any issues or have suggestions, please [create an issue](https://github.com/Mruczek2137/Rainbow-Hints-Broadcasts/issues) on GitHub.

## Configuration
To configure the plugin, edit the `config.yml` file:

```yaml
RainbowHints:
  IsEnabled: true
  Debug: false

  BroadcastMessage: "Good luck!"
  BroadcastDuration: 10
  RoundStartColors:
    - "red"
    - "orange"
    - "yellow"
    - "green"
    - "blue"
    - "purple"

  EscapeMessage: "You escaped!"
  EscapeMessageDuration: 10
  EscapeColors:
    - "blue"
    - "red"
    - "green"
    - "orange"
    - "white"
    - "yellow"
