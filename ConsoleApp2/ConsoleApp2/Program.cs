Console.Write("Enter the number of numbers: ");
int lN = int.Parse(Console.ReadLine());
int[] num = new int [lN];
for (int i=0; i<lN; i++)
{
    Console.Write("Enter number");
    num[i] = int.Parse(Console.ReadLine());
}
for(int i=0; i<lN; i++)
{
    if(num[i]%2 == 0)
    {
        Console.WriteLine(num[i] + "is Even");
    }
    else
    {
        Console.WriteLine(num[i] + "is odd");
    }
}


//Console.Write("Enter the number of numbers: ");
//int lN = int.Parse(Console.ReadLine());
//int[] num = new int[lN];
//string[] res = new string[lN];
//for (int i = 0; i < lN; i++)
//{
  //  Console.Write("Enter number" + i + " : ");
    //int val = int.Parse(Console.ReadLine());
    //if (val % 2 == 0)
    //{
      //  res[i] = "Value is Even";
    //}
    //else
    //{
      //  res[i] = "Value is odd";
    //}
    //num[i] = val;
//}
//for (int i = 0; i < num.Length; i++)
//{
  //  Console.WriteLine(num[i] + " is " + res[i]);
//}

