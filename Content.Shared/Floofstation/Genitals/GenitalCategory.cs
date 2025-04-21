using Robust.Shared.Serialization;

namespace Content.Shared.FloofStation.Genitals
{
    /// <summary>
    /// These are the categories of genitals that can be used for characters.
    /// Used to define if something is a booby or a belly or something else.
    /// </summary>
    [Serializable, NetSerializable]
    public enum GenitalCategory : byte
    {
        Abstract, // Stuff people shouldnt actually have, cus theyre not real
        Breasts,
        Butt,
        Belly,
        Testicles,
        Penis,
        Vagina,
        Ovipositor // im a chicken got it, ya beef jerky
    }
}
