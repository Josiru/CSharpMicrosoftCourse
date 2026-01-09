//Random random = new Random();
//int current = random.Next(1,11);

/*
do
{
    counter++;
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);*/

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");*/

/*
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);*/

/*//My solution
int CHeroHP = 10;
int CMonsterHP = 10;
Random random = new Random();
int attack = random.Next(1,11);
bool endbattle = true;

do
{
    //Hero's turn
    attack = random.Next(1,11);
    CMonsterHP = CMonsterHP - attack;
    Console.WriteLine($"Hero uses Tackle, Monster was damaged and lost {attack} health and now has {CMonsterHP} health.");
    if (CMonsterHP > 0)
    {
        attack = random.Next(1,11);
        CHeroHP = CHeroHP - attack;
        Console.WriteLine($"Monsters strikes, Hero was damaged and lost {attack} health and now has {CHeroHP} health.");
    }
    if (CHeroHP <= 0 || CMonsterHP <= 0) endbattle = false;

}while (endbattle);


if (CMonsterHP <= 0) Console.WriteLine("Hero Wins!");
else Console.WriteLine("Monster Wins!");
*/

//Solution
/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/


/*string? CPassword;
bool CPasswordValid = false;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("To create a password, please enter a string containing at leas 4 characters:");

do
{
    CPassword = Console.ReadLine();

    if (CPassword != null)
    {
        if (CPassword.Length >= 4) CPasswordValid = true;
        else Console.WriteLine("Your input is not valid, please try again.");
        
     }

} while (CPasswordValid == false);

validNumber = int.TryParse(CPassword, out numericValue);
Console.WriteLine(numericValue);*/


/////Project 1
/*
string? CUserEntry;
bool CValidNumber = false;
int CNumericValue = 0;

Console.WriteLine("Enter an integer value between 5 and 10.");

do
{
    CUserEntry = Console.ReadLine();
    if (CUserEntry != null)
    {
        CValidNumber = int.TryParse(CUserEntry, out CNumericValue);
        if (CValidNumber)
        {
            if (CNumericValue >= 5 && CNumericValue <= 10)
            {
                continue;
            } 
            else
            {
                Console.WriteLine($"You entered ({CNumericValue}). Please enter a number 5 and 10");
                CValidNumber = false;
            }
        }
        else Console.WriteLine("Sorry, you entered an invalid number, plase try again");
    }

}while(!CValidNumber);

Console.WriteLine($"You entered ({CNumericValue}) has been acepted");
*/

/////mini project 2
/// 
/*
using System.Diagnostics;
using System.Transactions;

string? CUserEntry;
string CRole;
bool CValidEntry = false;

Console.WriteLine("Enter your role name (Administration, Manager, User)");

do
{
    CUserEntry = Console.ReadLine();
    if (CUserEntry != null)
    {
        CRole = CUserEntry.ToLower().Trim();
        if (CRole == "administrator" || CRole == "manager" || CRole == "user")
            CValidEntry = true;
        else
            Console.WriteLine($"The role name that you entered, ({CUserEntry}) is not valid. Enter your role name (Administrator, Manager, User");
    }
}while(!CValidEntry);

Console.WriteLine($"Your input value {CUserEntry.Trim()} has been accepted");*/

//Mini Project 3
string[] CMyStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int CPeriodLocation = 0;
int CStringLength = 0;
string CStringProcess;

foreach (string CString in CMyStrings)
{
    if (CString.IndexOf(".") == -1)
    {
        Console.WriteLine(CString);
    }
    else
    {
        CStringProcess = CString;
        while((CStringLength + CPeriodLocation) < CString.Length)
        {
            Console.WriteLine(CStringLength + CPeriodLocation);
            Console.WriteLine(CString.Length);
            CPeriodLocation = CStringProcess.IndexOf(".");
            Console.WriteLine(CStringProcess.Substring(0, CPeriodLocation));
        
            CStringProcess = CStringProcess.Remove(0, CPeriodLocation+1).Trim(' ');

            Console.WriteLine(CStringProcess);
            CStringLength = CStringProcess.Length;
            Console.WriteLine(CStringLength);
            //Console.WriteLine(CStringProcess = CStringProcess.Remove(CPeriodLocation, CStringLength).Trim());
            CPeriodLocation = CStringProcess.IndexOf(".");
        }
    }
}