[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.
[Notes from in-class activity](https://docs.google.com/document/d/17mZRhYt_gy1qqJ6RG-Yek7lBylWTOTiz4EfzqFjAirQ/edit?usp=sharing)

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


I noticed that my initial plan was slightly different from Professor Reid's. Firstly, during the lecture, when we completed the exercise on our own, I mostly noted things about the player and the seed functionality. However, I did not note much about the UI, other than it changed when the player planted a seed. First of all, in my plan, I noted how the player would be able to move up, down, right, and left by using the WASD keys. I managed to implement this by updating the 'Update' method in the "Player" class with if statements to create the proper output depending on which key the player pressed—for example, moving right for D and so on. Similarly, to allow the player to plant seeds, I added functionality to the 'PlantSeed' method. I used a similar approach by creating an if statement to check when the player pressed the spacebar, which would then display the 'PlantPrefab' prefab at the player's location. To incorporate my mention of the changing values whenever the player plants a seed, I created an empty GameObject named PlantUI to store the text GameObjects. I attached the script component to this empty GameObject because I encountered a hurdle when I tried to attach the script to each of the text GameObjects individually, which became confusing. Then, to handle the updating values for seeds remaining and seeds planted, I worked within the "PlantCountUI" class. Here, I wrote code to convert the seed count values into string format, ensuring they could be displayed properly on the player's screen.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
