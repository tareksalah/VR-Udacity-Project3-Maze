VR Nanodegree Course - Project 3 (The Maze)
-------------------------------------------------------------------------------

Name: Tarek Salah Kamel
Time: 1 full Week .. Nearly 40 hours

I verified that I met all needed specs, hopefully :)

I added the following:
 - Fire torches particle system with their point lights
 - Fountain particle system
 - A nice Interactive UI at start to tell the user what to do. The waypoint system will be activated once the user hits the "Start" button.
 - Animations for collectables. 10 coins and the key.
 - Door and treasure chest animations.  I had to remake the animation clips of both
 - The UI inside the temple is also interactive with a button to restart the scene. It tells the user how many coins he/she collected
 - Ambient sound, and a door locked sound.

Google VR SDK version: From this link https://github.com/googlevr/gvr-unity-sdk/releases/tag/v1.0.3  ... GVR Unity SDK v1.0.3  (The one provided with the starter project 3 from Udacity)

There were some challenges
    - The GVR Camera at runtime always started with a fixed rotation not locking to the maze. I couldn't make it look to the maze entrance at start, but it should be ok to look at the fountain and trees at start. The solution I found online was to parent the main camera to an empty gameobject facing the maze. This actually solved it, However, it introduced a very annoying tilting problem to the left while moving inside the maze.
    - The baking of lights had many trials and always the scene is darker than before. I just used precompute realtime GI and it worked fine.
