namespace Content.Shared.FloofStation.Genitals;


/// <summary>
/// This is a size of genital!
/// </summary>
public sealed class GenitalSize
{
    /// <summary>
    /// The name of this size
    /// </summary>
    [DataField("name")]
    public string Name { get; private set; } = default!;

    /// <summary>
    /// The nude description of this size
    /// </summary>
    [DataField("nudeDescription")]
    public string NudeDescription { get; private set; } = default!;

    /// <summary>
    /// the clothed description of this size
    /// </summary>
    [DataField("clothedDescription")]
    public string ClothedDescription { get; private set; } = default!;

    /// <summary>
    /// Can this size be used for roundstart?
    /// </summary>
    [DataField("roundstart")]
    public bool Roundstart { get; private set; } = false;

    /// <summary>
    /// The sprites used for this size
    /// List of fancy structs that define the sprite and the layer it should be on
    /// </summary>
    [DataField("sprites", required: true)]
    public List<GenitalSprite> Sprites { get; private set; } = default!;
}
