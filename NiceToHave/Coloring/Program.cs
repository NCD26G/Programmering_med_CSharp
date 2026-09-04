namespace Coloring;

class Program
{
    /* 
        ASCII färg koder
        \e[0;30m	Black
        \e[0;31m	Red
        \e[0;32m	Green
        \e[0;33m	Yellow
        \e[0;34m	Blue
        \e[0;35m	Purple
        \e[0;36m	Cyan
        \e[0;37m	White
        \e[0m	    Reset
    */
    static void Main(string[] args)
    {
        var text = "\e[0;31mHej \e[0;32mpå \e[0;33mdig! \e[0mFantastiskt";
        Console.WriteLine(text);
    }
}
