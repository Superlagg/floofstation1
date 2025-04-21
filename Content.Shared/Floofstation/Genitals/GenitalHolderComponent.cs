using Robust.Shared.GameStates;


namespace Content.Shared.FloofStation.Genitals;


/// <summary>
/// This is where all your genitals live!
/// Contains a dictionary of genital prototypes and their overrides
/// The overrides are things set by the player, like size, color, and such
/// </summary>
[NetworkedComponent, RegisterComponent, AutoGenerateComponentState(true)]
public sealed partial class GenitalHolderComponent : Component
{
    /// <summary>
    /// Dictionary of genital prototypes and their srettings
    /// dict(genital prototype ID, genital srettings)
    /// </summary>
    [DataField, AutoNetworkedField]
    public Dictionary<string, GenitalSettings> Genitals { get; set; } = new();


}
