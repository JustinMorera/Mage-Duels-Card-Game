using UnityEngine;
using System.Collections.Generic;

namespace MageDuels
{
    [CreateAssetMenu(
        fileName = "New Card",
        menuName = "MageDuels/Cards/Minion"
    )]
    public class MinionCard : Card
    {
        public List<MinionSubtype> minionSubtypes;
        public int healthValue;
        public int moveValue;
        public List<Element> elements;
        public List<DraconicColor> colors;
    }
}