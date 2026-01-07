
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

