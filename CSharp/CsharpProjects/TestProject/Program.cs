Random dice = new Random(); //Instance of the class Random named dice
// Random dice = new() -> does the same as above on latest .net.


//New request address on the memory to store new objects on the Class
//Creates a new memory and stores the addres.
//returns the adresss memory to be used on dice.

//Random class 
int roll = dice.Next(1,7);
Console.WriteLine(roll);