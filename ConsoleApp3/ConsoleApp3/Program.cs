//int num = 3;
string names = @"hello\fonchu";  ///   Using verbatim (@ in front of the string) string to avoid escape charaters
string dirString = "C:\tusers\nFonchu\tDestop"; // using the normal string method
string dir_VerbatimString = @"C:\tuser\nFonchu\tDesktop";

string multiLineVerbatim = @"I went to a city named 

San Diego




During sumar holidays"; /// Verbatim string can be used to write on multiple lines

Console.WriteLine(names);
Console.WriteLine($"Normal string donot print escape characters: \n {dirString}\n\n\n");

Console.WriteLine($"Verbatim String instructs the compile to ignore the escape characters:\n {dir_VerbatimString}\n\n\n");

Console.WriteLine(multiLineVerbatim);

Console.WriteLine(nameof(names));

/**  Converting a string to an array   */

char[] sArray = names.ToCharArray();

foreach (char c in sArray)
{
    Console.WriteLine($"{c}\t");
}
Console.WriteLine(sArray.Length);

/**       Reversing an array    **/
Array.Reverse(sArray);    // returns a null and has to be converted to a string before use.
string r = new string(sArray);

Console.WriteLine("new string: " + sArray);