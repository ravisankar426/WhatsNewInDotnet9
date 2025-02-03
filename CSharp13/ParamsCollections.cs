/*
1. The params modifier is not limited to array types, use can use it with
any collection type that implements IEnumerable<T>, Span<T> and ReadOnlySpan<T>.
*/

public class ParamsCollections
{
    public static void Concat<T>(params IEnumerable<T> items)
    {
        Console.WriteLine("Params Collections IEnumerable<T>.");
        foreach(var item in items){
            Console.Write(item);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public static void Concat<T>(params ReadOnlySpan<T> items)
    {
        Console.WriteLine("Params Collections ReadOnlySpan<T>.");
        foreach(var item in items){
            Console.Write(item);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}