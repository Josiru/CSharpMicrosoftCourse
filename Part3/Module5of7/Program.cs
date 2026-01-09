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

