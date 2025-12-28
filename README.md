# Block Breaker Game
**Classic Arcade Action – Break Them All!**  

*Fast-Paced • Classic • Skill-Based*

One ball. One paddle.  
Break every block or it’s game over.

---

## About
A classic **Block Breaker (Brick Breaker)** style arcade game developed in **C# using Unity** for **Windows**.  
This project is one of my first complete and publishable C# games, focused on core gameplay mechanics rather than a practice or prototype build.

The game currently features **5 playable levels** with increasing challenge.

---

## Key Features
- Classic ball & paddle gameplay  
- Mouse-controlled paddle movement  
- 5 progressive levels  
- Multiple block types:
  - One-shot breakable
  - Two-shot breakable
  - Three-shot breakable
  - Invisible blocks
  - Unbreakable blocks  
- Score system with live UI update  
- Smooth ball physics with velocity randomization (anti-stuck behavior)  
- Sound effects for:
  - Paddle hits
  - Wall hits
  - Block damage & destruction  
- Particle effects on block destruction  
- Random item drops from blocks  
- Multi-ball power-up (Ball ×2 item)  
- Game Over system when all balls are lost  
- Optional auto-play mode (ball-follow paddle)  
- Clean, modular, and well-commented C# code  

---

## How to Play
1. Move the paddle using your mouse  
2. Click to launch the ball  
3. Break all breakable blocks to clear the level  
4. Catch falling items to gain power-ups  
5. Don’t let all balls fall — or it’s game over  

---

## Game Systems Overview
- **Ball System**  
  - Paddle-locked start  
  - Randomized velocity on collision  
  - Multiple active balls support  

- **Block System**  
  - Hit-based durability  
  - Visual damage stages  
  - Score & level progression tracking  
  - Random item spawning  

- **Level System**  
  - Automatic level progression  
  - Scene-based level loading  

- **Game Status Manager**  
  - Persistent score tracking  
  - Game speed control  
  - Auto-play option for testing  

---

## Tech Stack
- Unity (2D)  
- C#  
- TextMesh Pro  
- Built-in Unity Physics (Rigidbody2D & Colliders)  
- No external assets or paid plugins  

---

## Quick Start
```
git clone https://github.com/alrrezz/Block-Breaker-Game
```
Open the project in Unity Hub, select the Windows platform, and hit Play.

---

## Future Improvements
- Lives system with UI
- More power-ups
- More levels
- Level selection menu
- Save system
- Mobile support
- Visual polish & juice

---

## Credits
Developed by Alireza Pahlevanzadeh
Built with Unity
Sound & VFX powered by Unity built-in systems

---

## License
## License
This project is licensed under the **Creative Commons Attribution–NonCommercial 4.0 International (CC BY-NC 4.0)**.

You are free to use, modify, and learn from this project for **non-commercial purposes only**.
Commercial use is **not allowed** without explicit permission from the author.

---

Classic arcade fun never dies.
Give it a ⭐ if you enjoyed breaking blocks!

#Unity #CSharp #BlockBreaker #IndieGame #ArcadeGame #MadeWithUnity
