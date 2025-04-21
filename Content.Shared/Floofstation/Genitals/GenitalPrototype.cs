using Robust.Shared.Prototypes;


namespace Content.Shared.FloofStation.Genitals;


/// <summary>
/// A genital! This is a prototype that can be used to create genitals (and such) for characters.
/// </summary>
[Prototype("genital")]
public sealed class GenitalPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; private set; } = "owo";

    /// <summary>
    /// Category of the genital. defines if its a booby or a belly or something else.
    /// </summary>
    [DataField("category", required: true)]
    public GenitalCategory Category { get; private set; } = GenitalCategory.Belly;

    /// <summary>
    /// Name of the genital. Generally refers to the overall shape of the genital
    /// Like 'Pair of breasts' or 'furred spade' or 'Unholy drink cloaca'
    /// </summary>
    [DataField("name", required: true)]
    public string Name { get; private set; } = default!;

    /// <summary>
    /// What hides this genital. used to define if its hidden by underpants, shirts, or outfits
    /// todo: have it treat the public nudity license as effectively not wearing a jumpsuit
    /// todo: Make jumpsuits and such define which parts of the body they cover
    /// </summary>
    [DataField("hiddenBy", required: true)]
    public List<GenitalHiddenBy> HiddenBy { get; private set; } =
    [
        GenitalHiddenBy.Jumpsuit,
        GenitalHiddenBy.Underpants,
        GenitalHiddenBy.Undershirt
    ];
    /// <summary>
    /// What sort of stuff does this genital produce?
    /// Can be a reagent, or an item. Exude milk! Produce eggs! Ejerkulate screamen!!
    /// Can be null if it produces nothing.
    /// </summary>
    [DataField("produces")]
    public GenitalProduces? Produces { get; private set; } = null;

    /// <summary>
    /// Can you get this at roundstart from the character creation menu?
    /// Generally, yeah. Set to no if its an abstract or something
    /// </summary>
    [DataField("roundstart")]
    public bool Roundstart { get; private set; } = true;

    /// <summary>
    /// The dictionary of all the different sizes this genital can be.
    /// Heres where all the on-mob sprites are defined, as well as the size of the genital
    /// Must have at least one size, tho if its just one, it'll be locked to that size
    /// </summary>
    [DataField("sizes", required: true)]
    public Dictionary<string, GenitalSize> Sizes { get; private set; } = new();
}
