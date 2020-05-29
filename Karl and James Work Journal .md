**Karl and James Work Journal**
=============
**5/5 3pm Kick off Call**
---------------
* Meet and greet, got to know a little about each other
 * Discused how we were going to work on project
    * For communication landed on discord.
    * For code sharing and version control github was selected
 * Before working on project starts
    * James is learning about github
    * Discord Channel needs to be started
    * GitHub repository needs to be created and Project file needs to be added to repository
 * Next meeting is on 7/5
 
### 7/5 3pm Prep work 8am - 9:50am - Karl ###
* Created Github Repository
* Created Discord Channel
* Created Work Journal
* Created C# Project

**7/5 4pm -5:30pm Meeting**
---------------
* Went over GitHub
* Walked through push, pull and branches
* Explored GitHub Repository

### 14/7 2pm - 4pm - Karl ###
* Created Basic UI
   * Coded Menu Layout
      * Have second player hidden when one player is selected.
      * Have not created the sending of data between forms
   * Coded Basic radio buttons for selecting how many dice are being rolled
      * Labels created for player Names and Scores. Might change to textboxs depending on further layout
      * Added picture boxes for the dice
   * Selections one and Two completed
### 17/5 1am James ###
* Created Psuedo for potential Dice Check method

### 19/7 8am - 11am - 2pm - 4pm - Karl ###
* Section Three
   * Created set of methords to create the dice face
      * Each dice face methord is a set of dot methords - this helps with keeping the dots in the same spot over and over again.
      * The Dot methords are just fullellipse with cordinates - Maybe for further work, creating global vaiable that allow for one change to increase the size of the dots.
      * Exlorded hiding and unhiding pictureboxes when a amount of dice are slected so it just shows the amount of dice selected. (might look at having it create the picture boxes dynamically)
      * Created arrays for all the pictureboxs and graphics so we can access them as a group or just one at a time. This cuts down on repetitive calls to dice faces. had a massive if Statment changed to a loop with an array.
   * Explored the animation of changing the dots numbers before the final score.
      * Used a timer to create animation. worked well but needed asynchronous to allow the collection of numbers displayed.
      * Changed the timer to a basic "for loop" that changes all the dices faces to a random number for a random amount of time and a random amount times.
* Section Five and Six
   * Basic design was already created for selecting mutiple dice. Using radio buttons to control the amount of dice being selected. 
   * Choose a roll button allowing player to change mind before the rolling of the dice. This better simulats what happens in real world. Allows for hesitation of the roll.
   * Moved dice displaying to its own methord.
   * Moved Rolling dice to its own methord.
  
### 25/5 10pm - James ###
* Attempted variable carry over from Menu to game
* Create dice roll mockup (posted on discord)
     
### 26/5 6pm - 8pm - 10pm - 12am - James ###
* Created number checker and sorter for FrmSixOfOne.cs
* Started rule checker

### 27/5 12pm - 2pm - 4pm - 6pm - 8pm - 10pm - James ###
* Cleaned up cases inside of ScoreCheck()
* Added ThreeOfAKind to Game.cs
* Added rules data
* Created Rules Form

### 28/5 4pm - James ###
* Finished section 13
    * Originally intended to change the AI dice count based off the percentage difference between the player and the AI. 
    * However, I was unable to find the right bit of code online or in the notes to run inside the game. As a result, the AI simple bases its amount of dice based on if they are ahead (rolling 2-3 dice) or behind (rolling 3-6). This satisfies the bot's means of either playing it safe while winning, or making riskier moves if the bot is losing.

### 29/5 2pm-4pm - James ###
* Bug Fixes
    * Fixed tbxTotalWins to have each score of a different line (\r\n rather than \n).
    * Made it so that if its the AI's turn, the button remains hidden.