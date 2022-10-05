using System;
public class SamplesArray
{

    public static void Main()
    {

        // Creates and initializes a new integer array and a new Object array.
        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
        Object[] myObjArray = new Object[5] { 26, 27, 28, 29, 30 };
        int[,] arr2D = new int[,] { { 1,3,5,7 }, {2,4,6,8 } };
        IList<int> list = new List<int>();

        List<object> list2 = new List<object>();
        list2.Add(5);
        list2.Add('t');
        list.Add(1);

        Console.WriteLine(list2.Count);
        /*PrintValues(arr2D);

        Console.WriteLine(myObjArray);

        // Prints the initial values of both arrays.
        Console.WriteLine("Initially,");
        Console.Write("integer array:");
        PrintValues(myIntArray);
        Console.Write("Object array: ");
        PrintValues(myObjArray);

        // Copies the first two elements from the integer array to the Object array.
        System.Array.Copy(myIntArray, myObjArray, 2);

        // Prints the values of the modified arrays.
        Console.WriteLine("\nAfter copying the first two elements of the integer array to the Object array,");
        Console.Write("integer array:");
        PrintValues(myIntArray);
        Console.Write("Object array: ");
        PrintValues(myObjArray);
    }

    public static void PrintValues(Object[] myArr)
    {
        foreach (Object i in myArr)
        {
            Console.Write("\t{0}", i);
        }
        Console.WriteLine();
    }

    public static void PrintValues(int[] myArr)
    {
        foreach (int i in myArr)
        {
            Console.Write("\t{0}", i);
        }
        Console.WriteLine();
    }

    public static void PrintValues(int[,] arr)
    {
       /* for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                Console.Write(arr[i,j]);
            }
            Console.WriteLine();
        }*/
    }

}