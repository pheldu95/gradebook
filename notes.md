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

Testing
---------------
attributes, like [Fact] are attached to whatever follows it
The test will look for parts of code with Fact attached to it
Triple A of testing = arrange, act, assert
To allow us to access classes from our project, we needed to add a reference to the project. u can do this in the terminal. navigate to Gradebook.Tests, then run: dotnet add reference ../../src/GradeBook/GradeBook.csproj 
Now we can instantiate a Book for our test

Reference types vs value types
-----------------------------
a reference variable, like var b = new Book("grades"), is referencing another part of memory, references the Book Object
var x = 23 is a value type. it isn't referencing anything, it is holdign a value

A solution file is a file that keeps track of multiple projects
dotnet new sln creates a new solution file
dotnet sln add src/GradeBook/GradeBook.csproj  -- adds a project to the sln

Whenever you are working with something thjat has been defined by a class, then you are working with a reference type

string is a reference type that behaves like a value type
int, bool, double etc. are all value types. string is a special case

dotnet keeps track of everything u have created. it knows when there is a variable that is empty, and will get rid of it in the memory. don't have to do it manually

JUMPING STATEMENTS
to jump over lines of code, you can use the break statement to end a loop early
break;

continue; can be used to skip over the rest of the code in a loop, but continue to do the loop after skipping the remaining code for that iteration of the loop

EVENTS
not used much anymore
