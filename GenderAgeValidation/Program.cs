Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge  = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    { Console.WriteLine("Welcome to Instagram!"); }
    else
    { Console.WriteLine("You are too young to use Instagram."); }

}
else
{
    Console.WriteLine("Age can only be a number.");
}