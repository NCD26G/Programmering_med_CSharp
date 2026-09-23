namespace ReadAndWriteFiles;

class Program
{
    static void Main()
    {

        // Directory.Exists(Environment.CurrentDirectory + "/Data");
        string path = Environment.CurrentDirectory + "/Data/log.txt";
        if (File.Exists(path))
        {
            // Skriv till fil...
            string message = "Log added " + DateTime.Now.ToString();
            File.WriteAllText(path, message);
            // -----------------------------------------------------
            // Läs fil...
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("Fil eller katalog saknas");
        }



        /*
        // Stream klasserna...
        // Skriv till fil
        using StreamWriter sw = new(path);
        string message = "Nytt log ärende: " + DateTime.Now.ToString();
        sw.WriteLine(message);

        // Best practice...
        sw.Close();

        // Läs ifrån fil
        using StreamReader sr = new(path);
        string log = sr.ReadToEnd();
        Console.WriteLine(log);

        sr.Close();
        */
    }
}
