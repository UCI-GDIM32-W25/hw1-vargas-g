[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
How would you describe this game world in objects?
- Player
- Seeds
- UI for remaining and planted seeds 

What attributes and actions do these objects have?
- Player
  - Attributes
    - Bunny sprite 
  - Actions
    - Movement with WASD keys 
    - Plant seeds with space bar
- Seeds 
  - Attributes
    - Plant sprite
  - Will remain in the same spot where the player planted them.
- UI
  - Attributes
    - Text
  - Actions
    - Seeds planted increases when the player plants a seed and seeds remaining decreases.

How do these objects act on or affect each other?
- UI for seeds planted increases by one whenever the player plants a seed and seeds remaining decreases by one.

## Devlog
I noticed that my initial plan was slightly different from Professor Reid's. Firstly, during the lecture, when we completed the exercise on our own, I mostly noted things about the player and the seed functionality. However, I did not note much about the UI, other than it changed when the player planted a seed. First of all, in my plan, I noted how the player would be able to move up, down, right, and left by using the WASD keys. I managed to implement this by updating the 'Update' method in the "Player" class with if statements to create the proper output depending on which key the player pressed—for example, moving right for D and so on. Similarly, to allow the player to plant seeds, I added functionality to the 'PlantSeed' method. I used a similar approach by creating an if statement to check when the player pressed the spacebar, which would then display the 'PlantPrefab' prefab at the player's location. To incorporate my mention of the changing values whenever the player plants a seed, I created an empty GameObject named PlantUI to store the text GameObjects. I attached the script component to this empty GameObject because I encountered a hurdle when I tried to attach the script to each of the text GameObjects individually, which became confusing. Then, to handle the updating values for seeds remaining and seeds planted, I worked within the "PlantCountUI" class. Here, I wrote code to convert the seed count values into string format, ensuring they could be displayed properly on the player's screen.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting your plans to the code that you wrote! This Devlog will recieve full marks.

Next time, please put the activity text in the Devlog itself instead of just a link. You can format your break-down activities with the hyphen '-' symbol as suggested above. Also, you can remove the prompt text. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
