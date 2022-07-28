Console.Write("Enter your name: ");
string name = Console.ReadLine();
string revName = "";

while(name == null||name.Length == 0 || name == "")
{
    Console.Write("\n Please Enter your name: ");
    name = Console.ReadLine();
}
    for (int i = name.Length-1; i >= 0; i--)
    {
        revName = revName+name[i];
    }
    Console.Write("\n Reversing the letters of you name it gives: ");
Console.WriteLine(revName);
if(revName == name)
{
    Console.WriteLine("\n Your name is a palindrome👌😊");
}
else
{
    Console.WriteLine("\n Your name is not a palindrome😢😎");
}