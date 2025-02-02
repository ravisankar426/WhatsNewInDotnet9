using System.Diagnostics.CodeAnalysis;

public class NewFeature
{
    [FeatureSwitchDefinition("Feature.IsEnabled")]
    internal static bool IsEnabled =>
        AppContext.TryGetSwitch("Feature.IsEnabled", out var isNewFeatureEnabled) ?
        isNewFeatureEnabled : false;
    internal static void ImplementNewFeature()
    {
        Console.WriteLine("This is a New feature!");
    }
}
