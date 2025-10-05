using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using MageDuels;

public class CardDisplay : MonoBehaviour
{
    public Card cardData;
    public Image cardImage;
    public TMP_Text nameText;
    public TMP_Text energyCostText;
    public TMP_Text descriptionText; // For displaying card effects and abilities
    public TMP_Text healthText;
    public TMP_Text moveText;
    public TMP_Text rangeText;
    public TMP_Text trapChargesText;
    public TMP_Text subtypeText; // For displaying minion/spell attribute, subtype, elements, etc. 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay() // Not finished, review and complete
    {
        if (cardData != null)
        {
            cardImage.sprite = cardData.cardSprite;
            nameText.text = cardData.cardName;
            energyCostText.text = cardData.energyCost.ToString();
            descriptionText.text = cardData.description;

            if (cardData is MinionCard minionCard)
            {
                healthText.text = minionCard.healthValue.ToString();
                moveText.text = minionCard.moveValue.ToString();
                // rangeText.text = "";
                // trapChargesText.text = "";
                var allAttributes = minionCard.minionSubtypes
                    .Select(e => e.ToString())
                    .Concat(minionCard.elements.Select(e => e.ToString()))
                    .Concat(minionCard.colors.Select(e => e.ToString()));
                subtypeText.text = string.Join(", ", allAttributes);
                Debug.Log(subtypeText.text);
            }
            else if (cardData is SpellCard spellCard)
            {
                // healthText.text = "";
                // moveText.text = "";
                rangeText.text = spellCard.rangeValue.ToString();
                trapChargesText.text = spellCard.subtype == SpellSubtype.Trap ? spellCard.trapCharges.ToString() : "";
                var allAttributes = new[]
                {
                    spellCard.spellAttribute.ToString(),
                    spellCard.subtype.ToString(),
                    spellCard.subtype == SpellSubtype.Trap ? spellCard.trapActivation.ToString() : null
                }.Where(s => !string.IsNullOrEmpty(s));
                subtypeText.text = string.Join(", ", allAttributes);
                Debug.Log(subtypeText.text);
            }
        }
    }
}
