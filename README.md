# Toy Robot Simulator by using C# (Seigfred Visitacion)

**Toy Robot Simulator** <br/>
•The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units.<br/>
•There are no other obstructions on the table surface.<br/>
•The robot is free to roam around the surface of the table, but must be prevented from falling to destruction. <br/>
Any movement that would result in the robot falling from the table must be prevented, <br/>
however further valid movement commands must still be allowed.<br/>


**How to use:** 

The application have the 5 following commands:

* PLACE X,Y,F 
* MOVE 
* LEFT
* RIGHT 
* REPORT

• PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST. <br />
• The origin (0,0) can be considered to be the SOUTH WEST most corner. <br />
• The first valid command to the robot is a PLACE command, after that, any sequence of commands may be issued, in any order, <br />
  including another PLACE command. The application should discard all commands in the sequence until a valid PLACE command has been executed.<br />
• MOVE will move the toy robot one unit forward in the direction it is currently facing. <br />
• LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.<br />
• REPORT will show the current X,Y and F of the robot. <br />
• A robot that is not on the table should ignore the MOVE, LEFT, RIGHT and REPORT commands.<br />

**Sample Results** <br />
a)<br />
PLACE 0,0,NORTH <br />
MOVE <br />
MOVE <br />
RIGHT <br />
REPORT <br />
Output: 0,2,EAST<br />

b)<br />
PLACE 0,0,NORTH <br />
MOVE <br />
MOVE <br />
MOVE <br />
LEFT <br />
REPORT  <br />
Output: 3,0,EAST<br />

c)<br />
PLACE 1,3,EAST <br />
MOVE <br />
MOVE <br />
LEFT <br />
MOVE <br />
REPORT<br />
Output: 3,4,NORTH<br />

