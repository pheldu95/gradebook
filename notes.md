Running and building your project
---------------------------------
dotnet build compiles source code
    produces gradbook.dll --> our code but in binary

Saying Hello with C#
--------------------
Main is  method
it is the entry point of the application. when u run the application, it starts here
in a method, you can give parameters. every parameter needs a type and a name. In Main, args is short for argument
string[] args is a string array
dotnet run -- Duncan 
this is how you pass an arguemtn to main. run -- argument
you can find args in launch.json. here you can hardcode in the arguments to pass to Main. for debugging purposes usually

ADDING NUMBERS
var keyword lets the program figure out what the variable type is.

Module 4 Notes
----------------
class is a type.
how do you know when to create a new class? when u have a method that has to much code in it. like Main for example
You could make a method that calculates the average grade, called ComputeAverageGrade. Then the programmer looking at the code 5 months from now knows exactly what that method does.
Every class should be in a namespace. if it isn't, it could conflict with someone else's class that has the same name
Usually programmers only have one class in a file. so make a new file
A class is like a blueprint/cookie cutter
The cookies you stamp out/create, are objects
These objects will be of the same type as the class
A CONSTRUCTOR constructs objects 

Access modifiers -- private/public etc.
public means that code outside of the class has access to whatever has been declared as public
In OOP, we don't usually want our state in a class to be public
We want them to go through a method if they are messing with the state
Like using AddGrade

What does it mean for a method to be static? Like static void Main
I don't get it
