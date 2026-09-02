namespace ref_out_params;

class Program
{
    static void Main()
    {
        int age = 25;
        // int result = Demo(age);
        // int refResult = DemoRef(ref age);
        int outResult = DemoOut(age, out int outAge, out string test);

        // Console.WriteLine($"Local age: {age}");
        // Console.WriteLine($"Returned age: {result}");
        // Console.WriteLine("ByReference--------------------------");
        // Console.WriteLine($"Local age: {age}");
        // Console.WriteLine($"Returned age: {refResult}");
        Console.WriteLine("By Out Parameter--------------------------");
        Console.WriteLine($"Local age: {age}");
        Console.WriteLine($"Returned age: {outResult}");
        Console.WriteLine($"Returned out arg: {outAge}");
        Console.WriteLine($"Returned out arg: {test}");
    }

    static int Demo(int age) // CopyByValue - Kopierar endast värdet på variabeln (25)
    {
        age++; // Räkna värdet på argumentet
        return age;
    }

    static int DemoRef(ref int age) // CopyByReference - Kopiera adressen till variabeln
    {
        age++; // Manipulerar vi värdet på adressen
        return age;
    }

    static int DemoOut(int age, out int newAge, out string message)
    {
        newAge = age;
        newAge++;
        message = "Här kommer tillbaka ett meddelande ifrån min metod";
        return age;
    }
}
