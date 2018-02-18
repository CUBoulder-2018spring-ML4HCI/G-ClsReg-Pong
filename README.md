# G-ClsReg-Pong
Ryan Craig and Dan Nguyen

## Goals
The goals of this project changed throughout the project. Our final goal was
to have a game where one player uses a Microbit to control the paddle. The other
Microbit controles the ball speed. The paddle is controlled with classification while
The ball is controlled with regression.

## Tools
For this project we used a MicroBit along with Unity game engine.

## ML Choices
Using the wekinator input helper we cleaned up or data from the acceleramiter. For the paddle we did a k nearest neighbor as we only needed to send a move left or move right command given the value. As for the regression we used wekinator helper to get us an acceleration value this was then used to train a value of -1 to 1. This increased or decreased the puck speed.

## Accomplishments
Overall we accomplished our final goal. We have a working game that two people can play.

Cleaned up data using Wek-Input helper.

Used Wek-Input helper to extract features that we werent getting before.



## Challenges
Learning OSC in Unity was a challenge as well as getting some of the physics to correctly work.
Right now the regression works for ball speed but applying it to the physics engine causes some problems.


## What we learned
For this project we learned how to use Wek-Input helper. This allowed us to clean up the data
given some of the points were noisy. Also using this tool we extracted out the acceleration to use
for the regression. Applying all this with the physics engine of Unity we able to have a working game.
The physics engine was a new and had to be learned as well.  




[Demo](https://youtu.be/gbDQRojvGVM)
