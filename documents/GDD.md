# Game Design Document
## Table of Contents
- [Game Design Document](#game-design-document)
  - [Table of Contents](#table-of-contents)
  - [Game Pillars](#game-pillars)
    - [Overworld](#overworld)
    - [D-D-Duel!](#d-d-duel)
    - [Deck Builder](#deck-builder)
  - [Game Flow](#game-flow)
    - [Game Start](#game-start)
    - [Core Game](#core-game)
    - [Win/Lose Mechanic](#winlose-mechanic)
      - [Win Condition](#win-condition)
      - [Lose Condition](#lose-condition)
    - [Safe Zones](#safe-zones)
  - [Components](#components)
    - [Core](#core)
    - [Overworld](#overworld-1)
    - [Deck](#deck)
---
## Game Pillars
### Overworld
Explore a procedurally generated dungeon to find cards and gold.
### D-D-Duel!
Cards found in the overworld are used in combat in order to defeat the enemy.
### Deck Builder
Safe spots are found in the overworld where you can buy and sell cards to prepare for the next area.

---
## Game Flow
### Game Start
- Player chooses a deck before entering the dungeon (Dead Cells style).

### Core Game
- Upon entering the dungeon, the player must navigate the rooms in order to find more cards and gold.
- Enemies can be found in the dungeon, colliding with them will enter a battle state (Pokemon style)
- In the battle state, the player's skills are based on the cards in the deck. (Combat could be similar to Ni No Kuni 1 or go full card game in combat)

### Win/Lose Mechanic
#### Win Condition
- Player reaches end of level.

#### Lose Condition
- Player dies in combat.

### Safe Zones
- Upon reaching the end of the level, the player would go into a safe zone where they can heal, buy cards, and assemble their deck.

---

## Components
### Core
1. Player
2. Cards

### Overworld
1. Dungeon
2. Enemies
3. Obstacles
4. Safe Zones

### Deck
1. Card Seller
2. Player Upgrades