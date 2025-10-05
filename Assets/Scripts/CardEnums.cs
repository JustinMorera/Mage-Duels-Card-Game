namespace MageDuels
{
    public enum CardType
    {
        Minion,
        Spell
    }
    public enum MinionSubtype
    {
        Void,
        Arcane,
        Technological,
        Beastly,
        Angelic,
        Demonic,
        Elemental,
        Draconic,
        Undead,
        Human
    }

    public enum SpellAttribute
    {
        Charm,
        Luck,
        Skill,
        Wisdom,
        Cunning,
        Ferocity,
        Integrity,
        Valor,
        Will,
        Strength
    }

    public enum SpellSubtype
    {
        Hex,
        Blessing,
        Curse,
        Trap
    }

    public enum TrapActivation
    {
        Space,
        Row,
        Column
    }

    public enum Element
    {
        Air,
        Earth,
        Fire,
        Water
    }

    public enum DraconicColor
    {
        Black,
        Blue,
        Colorless,
        Green,
        Purple,
        Red,
        White,
        Yellow
    }
}