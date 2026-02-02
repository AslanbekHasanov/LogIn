

string[] logIn = {"doston"};
string[] password = {"doston2001$"};

belgi:
Console.WriteLine("Welcome my Project");
Console.WriteLine("1. LogIn");
Console.WriteLine("2. SignUp");

Console.Write("Enter your command: ");
int command = Convert.ToInt32(Console.ReadLine());


if (command == 1)
{
    Console.WriteLine("===== LogIn ======");
    Console.Write("Enter your logIn: ");
    string logInInput = Console.ReadLine();
    Console.Write("Enter your password: ");
    string passwordInput = Console.ReadLine();
    bool isAuthenticated = false;
    for (int i = 0; i < logIn.Length; i++)
    {
        if (logInInput == logIn[i] && passwordInput == password[i])
        {
            isAuthenticated = true;
            break;
        }
    }
    if (isAuthenticated)
    {
        Console.Clear();
        Console.WriteLine("You have successfully logged in!");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid logIn or password.");
    }
}




goto belgi;


