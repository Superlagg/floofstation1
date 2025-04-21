namespace Content.Shared.FloofStation.Genitals;


/// <summary>
/// This is a prototype for...
/// </summary>
public sealed class GenitalSettings
{
    /// <summary>
    /// Custom name of the genital
    /// </summary>
    public string? Name { get; private set; } = null;

    /// <summary>
    /// Custom description of the genital
    /// </summary>
    public string? Description { get; private set; } = null;

    /// <summary>
    /// Size of the genital. defaults to the first size in the list
    /// </summary>
    public string? Size { get; private set; } = null;

    // Stuff relating to the production of the genital

    /// <summary>
    /// ID of what it produces
    /// set to null if it doesn't produce anything
    /// </summary>
    public string? ProduceId { get; private set; } = null;

    /// <summary>
    /// Produces an item or a reagent?
    /// </summary>
    public bool? IsItem { get; private set; } = null;

    /// <summary>
    /// Amount of the item or reagent produced per manipulation
    /// </summary>
    public int? Amount { get; private set; } = null;

    /// <summary>
    /// How long does it take to produce the item or reagent?
    /// </summary>
    public float? Time { get; private set; } = null;

    /// <summary>
    /// Nutrition cost per unit of produce
    /// </summary>
    public int? NutritionCost { get; private set; } = null;

    /// <summary>
    /// Thirst cost per unit of produce
    /// </summary>
    public int? ThirstCost { get; private set; } = null;

    /// <summary>
    /// Verbiage used when you start manipulating the genital to exude the produce
    /// </summary>
    public string? VerbiageStart { get; private set; } = null;

    /// <summary>
    /// Verbiage used when you finish manipulating the genital to exude the produce
    /// </summary>
    public string? VerbiageFinish { get; private set; } = null;

    /// <summary>
    /// Verbiage used when you fail to manipulate the genital to exude the produce
    /// </summary>
    public string? VerbiageFail { get; private set; } = null;

    /// <summary>
    /// Colors!
    /// </summary>
    public List<Color> Colors { get; private set; } = new();
}

