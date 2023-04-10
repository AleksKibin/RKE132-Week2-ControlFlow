// See https://aka.ms/new-console-template for more information
// rakendus palub valida sugu: mees või naine ja lähtudes valikust, tervitab kas mr või mrs
// Welcome Mr/Ms Kasutaja perekonnanimi

Console.WriteLine("Please select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();
if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}