# DvtElevatorChallenge
This is a solution proposed by me to this challenge<br/><br/>
**Elevator Challenge**<br/>
Your task is to create a console application in C# using OOP principles that simulate the movement of elevators, with the goal being to move people as efficiently as possible.<br/><br/> 
The console application should provide the following features:<br/> 
**_show the status of the elevators, including which floor they are on, whether they are moving and in which direction, and how many people they are carrying_**
**_provides a way to interact with the elevators, including calling them to a specific floor and setting the number of people waiting on each floor_**<br/><br/> 
The console application should be able to offer the following:<br/>
**_support for multiple floors_**<br/>
**_support for multiple elevators_**<br/><br/> 
**Hints**<br/>
Given a pool of elevators, the program should send the nearest available elevator to that person.<br/><br/>
**Extra Credit**<br/>
For extra credit, allow a weight limit, expressed as a number of people, to be imposed on the elevators. You can assume every elevator in the simulation has the same weight limit.
Don’t forget about SOLID and DRY principles.
Also include unit tests for the code you have developed.

**A few considerations when you run the solution**<br/>
When the elevators are installed (the constructor for the building is called) all elevators are at ground level (floor 0)<br/>
There are some constants defined for the length of the list containing the list of elevators (each elevator has a letter from the alphabet assigned)
so the maximum size is 26<br/>
Also we can have above and underground floors (I have defined some boundaries for that, specifically for the maximum floor number).In this case, is 160 floors<br/>
Since on each floor there are some people waiting for the elevator, there is a maximum number of people that can be accommodated on each floor (the number is 80)<br/>

