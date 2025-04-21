using Content.Shared.Humanoid;
using Robust.Shared.Utility;


namespace Content.Shared.FloofStation.Genitals;


/// <summary>
/// This holds the sprite and the layer it should be on
/// Also color? nah
/// </summary>
public sealed class GenitalSprite
{
    /// <summary>
    /// The RSI of the sprite
    /// </summary>
    [DataField("rsi", required: true)]
    public ResPath Rsi { get; private set; } = default!;

    /// <summary>
    /// The state of the sprite
    /// </summary>
    [DataField("state", required: true)]
    public string State { get; private set; } = default!;

    /// <summary>
    /// Default layer for this sprite
    /// </summary>
    [DataField("layer", required: true)]
    public HumanoidVisualLayers Layer { get; private set; } = default!;
}
