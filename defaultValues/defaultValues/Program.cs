using System;

class Test
{
    static void Main()
    {
        int d = 8;
        Foo(ref d);
        Console.WriteLine(d);
        Console.WriteLine(sum(1,2,3,4,5));
    }

    static void Foo(ref int p)
    {
        Console.WriteLine(p);
        p = p + 1;
        Console.WriteLine(p);    
    }
    static int sum(params int[] ints)
    {
        int sum = 0;
        for(int i = 0; i < ints.Length; i++)
        {
            sum += ints[i];
        }
        return sum;
    }
}
