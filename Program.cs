// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string name = "Bob";
// name.Trim();

// string friends = $"Hello, {name}!";

// Console.WriteLine($"Hello, {name}!");
// Console.WriteLine("Hello "+ name + "!" );

// Console.WriteLine(friends);  
// Console.WriteLine(friends.Replace("Bob", "Damian"));

// Console.WriteLine(friends.Contains("Bob"));

// int a = 2100000000;
// int b = 2100000000;
// long d = (long)a + (long)b;
// long c = checked(a + b);
// Console.WriteLine(c);

// decimal db = 43.1M; // M is for decimal and it is explicit type
//double db = 32.1; natural type
//float fl = 38.3F; // F is for float
// decimal fl = 38.3M;

// decimal res = db + fl;
// Console.WriteLine(res); // 81.4


// int a = 15;
// int b = 4;
// bool test = a > b;

// if (test)
//     Console.WriteLine("a is greater than b");
// else if (a < b)
//     Console.WriteLine("a is less than b");
// else
//     Console.WriteLine("a is equal to b");



// for (char column = 'a'; column < 'k'; column++)
// {
//     Console.WriteLine($"The column is {column}");
// }

// var names = new string[]{"Bob", "Alice", "Charlie"}; //fixed length array
// List<String> names = new List<String>{"Bob", "Alice", "Charlie"};
// Console.WriteLine(names[0]);
// Console.WriteLine(names[^1]); // Charlie

// foreach(var name in names[1..]) //[1..^1][1..2]
// {
//     Console.WriteLine(name);
// }

// names = [..names, "David", "Eve"]; //adds elements to the end of list
// foreach(var name in names) //[1..^1][1..2]
// {
//     Console.WriteLine(name);
// }

// List<int> scores = [1,2,3,4,5,6,7,8,9,10];


//LINQ
// IEnumerable<int> scoreQuery = from score in scores
//                             where score > 5
//                             orderby score descending
//                             select score;
// IEnumerable<string> scoreQuery = from score in scores
//                             where score > 5
//                             orderby score descending
//                             select $"The score is {score}";

// int highScoreCount = scoreQuery.Count();
// int alternativeHSC = (from score in scores
//                             where score > 5
//                             orderby score descending
//                             select $"The score is {score}"
//                     ).Count();

// Console.WriteLine(scoreQuery.Count());

// foreach(string score in scoreQuery)
// {
//     Console.WriteLine(score);
// }

// IEnumerable<int> scoreQuery = 
//     from score in scores
//     where score > 5
//     orderby score descending
//     select score;

// var scoreQuery = scores.Where(s => s > 5).OrderByDescending(s => s);

// List<int> myscores = scoreQuery.ToList();

// foreach(var score in myscores)
// {
//     Console.WriteLine(score);
// }


// OOPS CLASSES
// var p0 = new Person(){firstName = "John", lastName = "Smith", birthday = new DateOnly(1980, 2, 1)}; //object initializer syntax

// var p1 = new Person("Bob", "Smith",new DateOnly(1980, 1, 1));  ///constructor syntax

// public class Person{
//     public string firstName;
//     public string lastName;

//     public DateOnly birthday;

//     // public Person(string fn, string ln, DateOnly bd){   //Constructor
//     //     firstName = fn;
//     //     lastName = ln;
//     //     birthday = bd;
//     // }
// }




//MORE PROPER HANDLING OF CLASSES
var p3 = new Person("jaga","strikas",new DateOnly(2000,1,1));
var p4 = new Person("shroud","sr",new DateOnly(2000,1,1));

p3.pets.Add(new Dog("Jimmy"));
p3.pets.Add(new Dog("subramani"));

p4.pets.Add(new Cat("Kitty"));

List<Person> peoples = [p3,p4];

foreach(var person in peoples){
    Console.WriteLine(person);

    foreach(var pet in person.pets){
        Console.WriteLine($"  {pet}");
    }
}


public class Person(string firstName, string lastName, DateOnly birthday)
{
    public string First{get;} = firstName;
    public string Last{get;} = lastName;
    public DateOnly bdate{get;} = birthday;

    public List<Pet> pets = new();

    public override string ToString()
    {
        return $"I am {First} {Last} ";
    }
}


public abstract class Pet(string firstName){
    public string first{get;} = firstName;
    public abstract string MakeNoise();

    public override string ToString() => $"I am {first} a {GetType().Name} and I make {MakeNoise()} noise";
}

public class Dog(string firstName):Pet(firstName){
    public override string MakeNoise() => "Woof Woof";
}

public class Cat(string firstName):Pet(firstName){
    public override string MakeNoise() => "Meow Meow";
}
