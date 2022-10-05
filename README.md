# INFR3110U-Midterm
Shesh Gaur - 100786399
Even - Programmer

Notes:
Any new files I added/created for this midterm are included in the "MidtermStuff" folder in Unity.

For Q3, I made MusicManager with an audio source, and added to the Coin script to call the MusicManager's functions. The coins / fairy are the brown spheres in the level.

For Q4, I decided to implement the debug observer I described in a previous question. Since we have already created the Observer parent class and Subject class in our lab, I decided to use those instead of unnecessarily rewriting them. I created the DebugChecker class which is a child of Observer, and added a subject to the PlayerController script.
In DebugChecker, I check for a gameobject in the constructor, have the OnNotify() function overridden, and then call CheckForOutOfBounds() function within it. This function checks it's game object's position to determine if they are out of bounds. If this is the case, a debug message is printed from the console (and text saying "OUT OF BOUNDS" is shown on the UI for demonstration purposes in the executable). 
In the Player's Start() function, I create a DebugChecker, and send the player in it's observer. I then use the player's subject to subscribe to this observer using the AddObserver() function.
In the level itself, I made an "OUT OF BOUNDS" area in bright red.

Credits:
- I used the Unity Project From Lab Week 3 as a Foundation for this project.
- Models from: https://quaternius.com/packs/ultimateplatformer.html 
- Used my own music
