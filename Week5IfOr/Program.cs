string username, password;

Console.WriteLine("Enter username:");
username = Console.ReadLine("");

Console.WriteLine("Enter password:");
password = Console.ReadLine("");

//if (username == "helloitsme" && password == "cats1234")
//{
//    Console.WriteLine("Welcome!");
//}
//else
//{
//    Console.WriteLine("Invalid username or password. Try again.");
//}

if (username == "helloitsme" || password == "cats1234")
{
    Console.WriteLine("Invalid username or password. Try again.");
}

else
{
    Console.WriteLine("Welcome!");
}