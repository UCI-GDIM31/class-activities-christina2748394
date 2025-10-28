# in-class-activities
## Devlogs
### W1
Hello world！

### W2
r, g, and b are numbers between 0-1 which are usually not whole numbers. 
The bounce variable is used to record the number of times the ball hits a wall, which will always be a whole number.
The error shows a line is missing ";", which reminds me to add ";" after each line of code.
### W3
Table6
For the  method named DidPlayerHitBeat in a rhythm game, the input type should be 2 floats to get the time when the beat comes up and the time the player press hit.
The return type should be a boolean beacuse it need a true or false to indecate whether the player hit the object.
metaphor
The class is like a recipe and components are what you can make with it, and the member variables are like ingredients and the methods are like the cooking steps.

### W4
Line5 declears _moveSpeed as a member variable, its a float and a SerializedField which we can tune in the inspector.
Line22 gives the value of vertical movement made each second to the translation varible. The Input.GetAxis() value reflects the direction of intended movement. The value will be 0 if no input on vertical aixis, a positive value if input is up, and a negative value if the input is down.  times The final value of vertical movement is calculated by multiplying the direction with the moveSpeed times delta time(distance traveled).
Line25 moves the transform on the z-axis by the amount of translation.

We added Rigidbodies to the cat and the ball, and we marked the goal with Is Trigger.
I had to link the Rigidbodies to the BounceOfWall Component to make it reacted correctlly when reaching the walls

 ### W5
Q1: What to put in the GetComponent<???> when we want to access a variable inside a script?
Answer: The component name. E.g gameObject.GetComponent<scriptname>.variable
Q2: How to call transform? For example you want to move the player inside the player script, do you need to reference the player object?
Answer: No, just start with transform.



## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
