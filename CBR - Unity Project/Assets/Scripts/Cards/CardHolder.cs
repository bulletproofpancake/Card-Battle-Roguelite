using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHolder : MonoBehaviour
{

    [SerializeField] private SpriteRenderer weaponSprite, damageSprite;
    [SerializeField] private int damageAmount;

    public void InitializeCard(CardData data)
    {
        weaponSprite.sprite = data.GetWeaponSprite();
        damageSprite.sprite = data.GetDamageSprite();
        damageAmount = data.GetDamageAmount();
    }
}
