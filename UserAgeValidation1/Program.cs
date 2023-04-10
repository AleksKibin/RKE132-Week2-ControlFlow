// rakendus palub kasutajal sisestada tema vanuse, kui kasutaja vanus >13 konsoolis kuvatakse
// you are too young to use insta, muuljuhul konsoolis kuvatakse "Welcome to Instagram!"

Console.WriteLine("Enter your age:");
string userAge = Console.ReadLine();
int userAgeNum = 0;
//boolean - true/false
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
//int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap; 13 - stack, säästab resurse
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");
if (isAgeNumber)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Please enter a valid age");
}