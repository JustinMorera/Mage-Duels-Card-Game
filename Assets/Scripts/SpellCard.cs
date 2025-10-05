using UnityEngine;

namespace MageDuels
{
    [CreateAssetMenu(
        fileName = "New Card",
        menuName = "MageDuels/Cards/Spell"
    )]
    public class SpellCard : Card
    {
        public SpellAttribute spellAttribute;
        public SpellSubtype subtype;
        public int rangeValue;
        public int trapCharges;
        public TrapActivation trapActivation;

    }
}
