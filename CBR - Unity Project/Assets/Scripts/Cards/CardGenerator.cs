using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] private GameObject cardHolderTemplate;
    [SerializeField] private RandomSpriteSelection weaponSelection, damageSelection;

    private void Start()
    {
        SpawnCard();
    }

    private void SpawnCard()
    {
        CardData data = new CardData(weaponSelection.GetRandomSprite(),damageSelection.GetRandomSpriteWithPosition());
        GameObject card = Instantiate(cardHolderTemplate);
        CardHolder holder = card.GetComponent<CardHolder>();
        holder.InitializeCard(data);
    }
}
