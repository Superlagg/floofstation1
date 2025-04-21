namespace Content.Shared.FloofStation.Genitals;


/// <summary>
/// This defines what a genital produces, like semen or milk or eggs
/// </summary>
public sealed class GenitalProduces
{
    /// <summary>
    /// Which category of genital this should inherit the produce from
    /// Picks the first one it finds
    /// Mainly so you can use your testicles to generate semen for your penis
    /// </summary>
    [DataField("inheritFrom")]
    public GenitalCategory? InheritFrom { get; private set; } = null;

    /// <summary>
    /// The ID of the prototype that this genital produces.
    /// Should be a reagent or an item. It might support mobs, but thats on you
    /// </summary>
    [DataField("produceId", required: true)]
    public string ProduceId { get; private set; } = default!;

    /// <summary>
    /// Is it an item? Otherwise, its a reagent (and it needs a container)
    /// </summary>
    [DataField("isItem")]
    public bool IsItem { get; private set; } = false;

    /// <summary>
    /// How many / how much of the item or reagent this genital produces per manipulation
    /// items should stay at 1, but you do you
    /// </summary>
    [DataField("amount")]
    public int Amount { get; private set; } = 1;

    /// <summary>
    /// How much nutrition/hunger does it cost per unit of produce when produced?
    /// </summary>
    [DataField("nutritionCost")]
    public int NutritionCost { get; private set; } = 0;

    /// <summary>
    /// How much thirst does it cost per unit of produce when produced?
    /// </summary>
    [DataField("thirstCost")]
    public int ThirstCost { get; private set; } = 0;

    /// <summary>
    /// How long, in seconds, does it take to produce the item or reagent?
    /// Could make it long, for like, laying eggs or ejerkulation
    /// Or short, for like, milk or something
    /// </summary>
    [DataField("time", required: true)]
    public float Time { get; private set; } = 5f;

    /// <summary>
    /// Verbiage used when you start manipulating the genital to exude the produce
    /// </summary>
    [DataField("verbiageStart", required: true)]
    public string VerbiageStart { get; private set; } = default!;

    /// <summary>
    /// Verbiage used when you finish manipulating the genital to exude the produce
    /// </summary>
    [DataField("verbiageFinish", required: true)]
    public string VerbiageFinish { get; private set; } = default!;

    /// <summary>
    /// Verbiage used when you fail to manipulate the genital to exude the produce
    /// like you get interrupted or something
    /// </summary>
    [DataField("verbiageFail", required: true)]
    public string VerbiageFail { get; private set; } = default!;
}
