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

### 19/5 8am - 11am - 2pm - 4pm - Karl ###
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
  

### 25/5 4pm -7pm - Karl ###
* Created Dice Class to handle counting the number a particcualr number is rolled
* Created Player Class to handle what a player in a game.
* Created Game Class to handle all games in a Session
* Created Session class to handle the all games while just two player or one player is playing
    * This class was created so that overall vairbles where able to be handled with out being deleted over and over
    * Also made the code easier to read once we had a class teird approch to the project



### 25/5 10pm - James ###
* Attempted variable carry over from Menu to game
* Create dice roll mockup (posted on discord)

### 26/5 9am - 2pm - Karl ###
* Created methords to handle the end of the game in both session and in game clases
    * Issues found during testing of end game bethords with preset data
    * Have tried to have account of all senarios for the game to end, while making them generic so there aren't multiple methods for ending the game
    * Game up with two diffect senarios where the game will and who they should be handled
    * Changed all End game methords to return a bool instead of a number
* Created methods to handle refreshing elements as needed.
* Created correct labeling for six of one form.
* Fixed issue with incremented dice class. Made Dice variables read only, allowing for incremented adustment of dice

### 26/5 6pm - 8pm - 10pm - 12am - James ###
* Created number checker and sorter for FrmSixOfOne.cs
* Started rule checker

### 27/5 10am - 4pm - Karl ###
* Ran into issue passing session object from one form to another.
    * Issue fixed was not creating the form correctly from menu to main game form.
* Cleaned up code around display and anchorged all object in six of one form.
* Realised all classes were created using Java standards get and set methords redesigned all classes so that they are in C# class standards

### 27/5 12pm - 2pm - 4pm - 6pm - 8pm - 10pm - James ###
* Cleaned up cases inside of ScoreCheck()
* Added ThreeOfAKind to Game.cs
* Added rules data
* Created Rules Form


### 28/5 12pm - 5pm - Karl ###
* Created Ai class which inherits player.
    * This will only be used for methods for Ai player
* Removed unused variables though out the program
* Added new labels to show how many times a player had won a game that session.
* Added Bool variable to handle ai control in each session

### 28/5 4pm - James ###
* Finished section 13
    * Originally intended to change the AI dice count based off the percentage difference between the player and the AI. 
    * However, I was unable to find the right bit of code online or in the notes to run inside the game. As a result, the AI simple bases its amount of dice based on if they are ahead (rolling 2-3 dice) or behind (rolling 3-6). This satisfies the bot's means of either playing it safe while winning, or making riskier moves if the bot is losing.

### 29/5 11am - 2pm -- 3pm - 4pm -- 5pm - 7pm  - Karl ###
* Tried to get Ai class working
    * Could not call Ai class on player array correctly
    * Ended up merging the AI and player classes.
* Added missing comments in the code.
* Moved code out of roll button so that Ai could roll the dice with out having to call the on click methord for roll dice which players use.
* Fixed issue with scoring being assigned instead of being +=


### 29/5 2pm-4pm - James ###
* Bug Fixes
    * Fixed tbxTotalWins to have each score of a different line (\r\n rather than \n).
    * Made it so that if its the AI's turn, the button remains hidden.