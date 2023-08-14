Console.Write("Input username: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
    Console.WriteLine("Hooray, it's MARY!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}