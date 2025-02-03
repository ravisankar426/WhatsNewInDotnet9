/*
1. In C# 13, a new escape sequence \e has been introduced to represent 
the ESCAPE character (Unicode U+001B).
2. Benifits are improved readability, reduced errors with 
hexadecimal interpretations, consistent with other common escape sequences.
*/
public class EscapeSequence
{
    internal static void Display()
    {
        Console.WriteLine("\e[1mThis is a text in bold.\e[0m");
        Console.WriteLine("\e[31mThis is red text.\e[0m");
        Console.WriteLine("\e[32mThis is green text.\e[0m");
        Console.WriteLine("\e[34mThis is blue text.\e[0m");
    }
}