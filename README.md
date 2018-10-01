# C-Dice-Game
C# Windows Form Application Dice Game: Craps

Created the dice game, Craps using a C# Windows Form in Visual Studio. The game is attached to a SQL database for storing the data for the player and their game history. 

There are many bets and odds that can be played, but this app is only foxued on the craps/point part of the game and is soley focused on wins and losses.

# How To Play
- The player has two standard dice, each with six faces, numbered 1 through 6.
- The player will roll both dice at the same time, landing on a random side. 
- If the sum of both dice is 7 or 11 on the first roll, the player wins. 
- If the sum of both dice is 2, 3, or 12 on the first roll, then ‘Craps’ is the result, and the player loses. 
- If the sum of both dice is 4, 5, 6, 8, 9, or 10 on the first roll, then that sum becomes the player’s “point”. 
- Once the point has been set, then the rules of the game change. If at any time after the first roll, a 7 is rolled, the player loses and the point is reset. 
- If the player rolls the point, then the player wins. Hitting the point also resets the point.
- When the point is reset, the game starts over, and the next roll of the dice acts like the first roll of the dice again. 

# SQL Database
* The following is stored in the database: 
  - The player’s details (Id and name) 
  - The result of each round including the sum of each of their rolls, point (if set), and the win/lose/null result. 
  - A combination of the player and game history.
  
# Player Management
- Allows user to create/edit/delete player profile.
- Allows user to select previously created profile, and continue playing.
- Allows user to clear game history per player profile.
- The game is a single player game and only allow on player profile to be used when attempting to play.
- A player profie must be active before a user can play the game.

# REST API
- Instead of using a random number generator to return the value of the dice, this app uses an online REST API to capture each die roll. The API provides a JSON string of values that include a result value that is a random number between 1-6. I serialized the JSON string to an object instead of parsing the value out of the string.

