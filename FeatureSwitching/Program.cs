if (NewFeature.IsEnabled)
{
    NewFeature.ImplementNewFeature();
}
else
    Console.WriteLine("Hello World!");


/*
    1. Can Enable of Disable specific features at runtime without modifying the code.
    2. Helps in Feature rollouts, A/B testing and environment specific configurations.
    3. Enable APIs for selected users before full release.
*/
