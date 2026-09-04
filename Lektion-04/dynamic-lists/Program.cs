using System.Collections;

namespace dynamic_lists;

class Program
{
    static void Main()
    {
        // =============================================================
        // Basic Lists - ArrayList - Ej rekommenderad längre
        // =============================================================

        /*
        ArrayList demo = new ArrayList();
        // ArrayList demo = [];
        demo.Add("Michael");
        demo.Add(23);
        demo.Add(true);
        demo.Add(new { name = "Kalle", age = 25 });
        demo.Add(3.75);

        // int result = 0;
        foreach (var item in demo)
        {
            Console.WriteLine(item);
            // result += (int)item;
            // Console.WriteLine(result);
        }

        Console.WriteLine(demo.Capacity);
        Console.WriteLine(demo.Count);
        Console.WriteLine(demo.Contains("Michael"));
        */

        /*
        // =============================================================
        // Basic Lists - List<T> - List Of Type
        // =============================================================
        List<string> movies = new List<string>();
        // List<string>movies = [];
        movies.Add("Bucket List");
        movies.Add("Batman");
        movies.Add("Paw Patrol");

        Console.WriteLine($"Antal filmer: {movies.Count}");
        Console.WriteLine($"Listans kapacitet: {movies.Capacity}");

        // foreach(string movie in movies){}
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }

        Console.WriteLine("===============================================");
        Console.WriteLine("Movies in reversed order");
        Console.WriteLine("===============================================");
        movies.Reverse();

        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }

        Console.WriteLine("===============================================");
        Console.WriteLine("Movies in sorted order");
        Console.WriteLine("===============================================");
        movies.Sort();

        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }

       */

        /*
        // =============================================================
        // Basic Lists - Queue<T> Type Of T
        // =============================================================

        Console.WriteLine("===============================================");
        Console.WriteLine("Queue");
        Console.WriteLine("===============================================");

        Queue<string> comics = new Queue<string>();
        // Queue<string> comics = [];

        comics.Enqueue("Buster");
        comics.Enqueue("Läderlappen");
        comics.Enqueue("X9");

        foreach (var item in comics)
        {
            Console.WriteLine(item);
        }

        comics.Dequeue();

        foreach (var item in comics)
        {
            Console.WriteLine(item);
        }

        */

        // =============================================================
        // Basic Lists - Stack<T> Type Of T
        // =============================================================

        Console.WriteLine("===============================================");
        Console.WriteLine("Stack");
        Console.WriteLine("===============================================");

        Stack<int> tests = new Stack<int>();
        // Stack<int> tests = [];
        tests.Push(1);
        tests.Push(2);
        tests.Push(3);
        tests.Push(4);
        tests.Push(5);

        foreach (var item in tests)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("===============================================");
        Console.WriteLine("Stack efter pop()");
        Console.WriteLine("===============================================");

        tests.Pop();
        foreach (var item in tests)
        {
            Console.WriteLine(item);
        }
    }
}
