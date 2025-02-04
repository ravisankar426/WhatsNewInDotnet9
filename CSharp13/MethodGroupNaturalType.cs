
/*
1. C# 13 enchances compilers ability to determine the natural type by scope-by-scope evaluation
and pruning inapplicable methods.
2. This leads to more efficient and accurate overload resolution, allowing developers to write 
cleaner and more intuitive code when working with method groups.
*/

public class Calculator
{
    public int Add(int a, int b) => a+b;
    public double Add(double a, double b) => a+b;
}