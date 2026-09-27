# Unity_ActionGame

A third-person action game prototype developed in **Unity 2018.4.31f1**. This project is presented as a **programming portfolio piece**: my original work is the gameplay and supporting C# code. The character models, animations, environment art, visual effects, and other art assets were obtained from Unity Asset packages and were **not created by me**.

## Project Overview

The player moves through a sequence of combat areas, fights wolf enemies and a boss, collects items and coins, and progresses through the level. The prototype brings together character controls, enemy behaviour, combat, UI feedback, camera behaviour, and scene transitions.

## My Contributions

- Wrote the C# scripts under [`Assets/Script/`](Assets/Script/) for player movement, attacks, jumping, damage reactions, item interaction, and gameplay state.
- Implemented enemy behaviour for wolves and the boss, including pursuit, attack range checks, hit reactions, and the boss's wolf spawning behaviour.
- Programmed health and skill resource handling, collectible interactions, coin counting, camera follow and shake, and level progression with fade transitions.
- Integrated these systems with third-party assets to make a playable action game prototype.

**Asset attribution:** The visual assets, including characters, character animations, and environmental art, come from Asset packages. They are included to demonstrate the gameplay implementation and are not claimed as my original artwork. The portfolio contribution showcased here is **programming and gameplay integration**.

## Controls

| Action | Keyboard and mouse | Gamepad input in the script |
| --- | --- | --- |
| Move | `W/A/S/D` or arrow keys via Unity's default Horizontal/Vertical axes | Configured movement axes |
| Jump | `Space` | Joystick 1, Button 0 |
| Basic attack | Left mouse button | Joystick 1, Button 2 |
| Heavy attack | Right mouse button; consumes 0.1 skill | Joystick 1, Button 3 |
| Kick | Hold `E` and click the right mouse button; consumes 0.3 skill | Joystick 1, Button 1 |
| Pick up an available item | `R` while in range | Joystick 1, Button 5 |

Movement is relative to the camera's facing direction. Moving during an attack interrupts that attack. Gamepad button numbers are Unity input identifiers; the physical button labels can vary by controller and input configuration.

## Technical Highlights

- **Player controller:** [`PlayerControl.cs`](Assets/Script/Character/PlayerControl.cs) handles camera-relative movement, animation triggers, attacks, jumping, hit feedback, and item interaction.
- **Enemy AI:** [`WolfControl.cs`](Assets/Script/Character/WolfControl.cs) and [`BossControl.cs`](Assets/Script/Character/BossControl.cs) handle detection, movement, attacks, and boss-specific spawning.
- **Level flow:** [`GameManager.cs`](Assets/Script/System/GameManager.cs) manages four level states, enemy groups, transitions, and the ending condition.
- **UI and collectibles:** [`PlayerBar.cs`](Assets/Script/UI/PlayerBar.cs), [`CoinManage.cs`](Assets/Script/Item/CoinManage.cs), and [`ItemGet.cs`](Assets/Script/Item/ItemGet.cs) manage health, skill resources, coins, and pickups.

## Open the Project

1. Clone or download this repository.
2. Open the project folder with **Unity 2018.4.31f1**.
3. Open `Assets/Scenes/Menu.unity` and enter Play mode. Press any key to reveal the menu, then select Start. The menu loads `Assets/Scenes/SampleScene.unity`.

## Portfolio Note

This submission highlights my interest in interactive gameplay systems and C# programming. The repository includes third-party art and packages as implementation resources; please assess the original scripts and their gameplay integration as my work.
