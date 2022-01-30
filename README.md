# Zombie-Attack

Here are collected scripts from my first game. They're not perfect, but I haven't seen them on the internet for sure.

Rules of the game:
- On the main screen there is a button "start the game" and the maximum number of points scored by the player.

- View from above. The player is positioned at the bottom of the screen, centered horizontally. The player has a weapon that constantly shoots. Aiming is carried out by tap or swipe across the screen. On the player from different sides (top, left, right) are waves of zombies. The goal of the game is to prevent zombies from getting to the player. The game continues until the zombie reaches the player.

- When losing, the losing screen is shown, which shows the current points scored and the exit button to the menu.

All parameters should be easily editable.

The difficulty of the game increases with time. At the start of the game, 1 zombie spawns every 2 seconds, every 10 seconds the game reduces the spawn time by 0.1 seconds, to a minimum value of 0.5.

Has a rate of fire of 10 shots per second, each bullet takes 1 HP from zombies

In total there will be 3 types of zombies:
Zombie - ordinary. It has a speed of 2 units per second and 10 hp, 7 points are given for killing it. Spawn chance - 60%
Zombies - experienced. It has a speed of 3 units per second and 10 hp, 12 points are awarded for killing it. Spawn chance - 30%
Armored zombie. It has a speed of 1 unit per second and 50 hp, 30 points are given for killing it. Spawn chance - 10%
