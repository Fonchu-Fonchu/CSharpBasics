void workWithNumbers()
{
    int a = 12, b = 2;
    Console.WriteLine($"Sum is {a + b}");
    Console.WriteLine($"Difference is {a-b}");
    Console.WriteLine($"Quotient is: {a / b}");
    Console.WriteLine($"Multiple is: {a * b}");
}

void typeLimits()
{
    Console.WriteLine($"The maximum int is: {int.MaxValue}");
    Console.WriteLine($"The minimum int is: {int.MinValue}\n\n");

    Console.WriteLine($"The maximum short is: {short.MaxValue}");
    Console.WriteLine($"The minimum short is: {short.MinValue}\n\n");

    Console.WriteLine($"The maximum long is: {long.MaxValue}");
    Console.WriteLine($"The minimum long is: {long.MinValue} \n\n");



    Console.WriteLine($"The maximum long is: {long.MaxValue}");
    Console.WriteLine($"The minimum long is: {long.MinValue} \n\n");
}

void workWithList()
{
    var names = new List<string> { "Nnene", "Geraldine", "Job", "Arshly"};
    foreach (var name in names)
    { 
        Console.WriteLine(name.ToUpper()); 
    }
}

//workWithNumbers();

//typeLimits();

workWithList();