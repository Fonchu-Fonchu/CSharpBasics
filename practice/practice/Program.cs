///// 
///Language integrated Queries
/// LINQs
/// 

/*
int[] numbers = new int[10] {0,1,2,3,4,5,6,7,-8,9};

var numQuery = from num in numbers
               where (num % 2 == 0)
               select num;

foreach (var num in numQuery)
{
    Console.Write(num+ " ");
}



int[] numbers = new int[8] {0, -4, 2, 3, -6, 5, -8, 1 };

var negQuery = from n in numbers
               where n > 0 & (n - 1) > 0
               select n;

foreach (int val in negQuery)
{
    Console.WriteLine(val);
}

var lenQuery = from n in numbers
               select n;
Console.WriteLine(lenQuery);

*/
//// Enums
/// Defines a set of constant values or better still multiple values for a single constant
/// 
/*
class enumTest
{
    public enum test
    {
        num = 0,
        text,
        guess,
        think

    }

    static void Main()
    {
        var hm = test.num;
        Console.WriteLine((int)test.text);
    }
}
*/



////    Delegates
///  <summary>
/// Help to define functions return type and the parameter types that the function can take.
///     Methods that uses delegates are have a static modifier.
/// 
///  Can be within a namespace or a class or a struct
/// </summary>

using System;
/*
class Delegates
{

    delegate int Transforme(int x);

    static void Main()
    {
        Transforme t = new Transforme(Square);
        Console.Write(t(3));
    }
    static int Square(int x) => x * x;
}

*/

/// <sumary>
///     Delegates in details
/// </sumary>
/// 


/*
namespace DelegateTest
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        public delegate bool FilterPersonDelegate(Person p);

        static void Main(string[] args)
        {
            Person p1 = new Person() { Age = 23, Name = "Arshly" };
            Person p2 = new Person() { Age = 20, Name = "John" };
            Person p3 = new Person() { Age = 30, Name = "Test" };
            Person p4 = new Person() { Age = 70, Name = "Fonchu" };

            List<Person> people = new List<Person>() { p1,p2,p3,p4};
            List<Person> test = new List<Person>();

            people.Add(item: new Person(){Age=12, Name="Think" });

            DisplayPeople("Adults", people, isAdult);
            DisplayPeople("Chidren", people, isChild);
            DisplayPeople("Seniors", people, isSenior);
        }


        static void DisplayPeople(String title, List<Person> people, FilterPersonDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
            Console.WriteLine("\n\n");
        }

        static bool isAdult(Person p)
        {
            return p.Age < 40 && p.Age>18;
        }

        static bool isChild(Person p)
        {
            return p.Age < 18;
        }

        static bool isSenior(Person p)
        {
            return p.Age >= 40;
        }
    }
}

*/

namespace EventHandlingPractice
{
    public delegate string MyDel(string str);
    class EventProgram
    {
        event MyDel myDelEvent;

        public EventProgram()
        {
            this.myDelEvent += new MyDel(this.welcomeUser);
        }

        public string welcomeUser(string name)
        {
            return "Welcome " + name;
        }

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            EventProgram program = new EventProgram();
            string result = program.myDelEvent("Fonchu");
            Console.WriteLine(result);
        }
    }
}