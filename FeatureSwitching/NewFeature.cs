/*
    1. Can Enable of Disable specific features at runtime without modifying the code.
    2. Helps in Feature rollouts, A/B testing and environment specific configurations.
    3. Enable APIs for selected users before full release.
*/

using System.Diagnostics.CodeAnalysis;

public class NewFeature
{
    [FeatureSwitchDefinition("Feature.IsEnabled")]
    internal static bool IsEnabled =>
        AppContext.TryGetSwitch("Feature.IsEnabled", out var isNewFeatureEnabled) ?
        isNewFeatureEnabled : false;
    internal static void ImplementNewFeature()
    {
        Console.WriteLine("New Feature is Enabled!");
    }
}
