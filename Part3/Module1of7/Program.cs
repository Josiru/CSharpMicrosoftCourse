/*
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); 
*/
/*
//This is False
Console.WriteLine("a" != "a");
//This is Treu
Console.WriteLine("a" != "A");
//Also True
Console.WriteLine(1 != 2);

//Finally this is false
string myValue = "a";
Console.WriteLine(myValue != "a");*/

//Conditional operator @?:
/*int saleAmount = 1000;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");*/

//Code Challenge: Display the result of a coin flip.
/*Random flip = new Random();
string coinFlip;
coinFlip = flip.Next(2) < 1 ? "Head" : "Tails";
Console.WriteLine(coinFlip);*/

//Excercise: Challenge Activity with Boolean expresions
string permission = "|Manager";
int level = 10;

if (permission.Contains("Admin"))
{
    if (level > 55)
    Console.WriteLine("Welcome, Super Admin user");
    else
    Console.WriteLine("Welcome, Admin user.");

}
else if(permission.Contains("Manager"))
{
    if(level >= 20)
    Console.WriteLine("Contact an Admin for access");
    else
    Console.WriteLine("You do not have sufficient privileges.");
}
else 
Console.WriteLine("You do not have sufficient privileges.");