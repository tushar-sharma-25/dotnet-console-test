namespace notes;

public class Delegates
{

    public record Hero(string name, bool canFly, string alias);
    // we can not use var directly in class
    public static List<Hero> heros = new List<Hero>(){
            new ("Tushar", true, "tus" ),
            new ("Max", false, "m" ),
            new (string.Empty, true, "home" )
        };

    //Predicate => special delegate the take a data structure as input and return bool
    // public delegate bool Condition<T>(T DataStr); // replaced by func

    public static void Main()
    {
        // var result = Filter(heros, (hero)=>hero.canFly);
        // foreach(var h in result){
        //     Console.WriteLine(h.alias);
        // }

        // Generic method can be used for any type of collection
        // foreach(var item in Filter(new []{"max", "bob", "tushar"} , name => name.StartsWith("tu"))){
        //     Console.WriteLine(item);
        // }


        // using Func to return multiple values
        Func<string, (string name, bool isRegistered)> getUser = (string n) =>
        {
            bool isRegistered = true;
            string name = n;
            return (name, isRegistered);
        };

        // Example usage
        var user = getUser("Alice");
        Console.WriteLine($"Name: {user.name}, Is Registered: {user.isRegistered}");


    }

    // This is how LINQ Where is implemented , with Generics + Delegates
    public static IEnumerable<T> Filter<T>(IEnumerable<T> data, Func<T, bool> cond)
    {
        foreach (var item in data)
        {
            if (cond(item))
            {
                yield return item;
            }
        }
    }
}