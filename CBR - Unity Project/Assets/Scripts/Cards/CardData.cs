using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData
{
    private Sprite _weaponSprite, _damageSprite;
    private int _damageAmount;

    public CardData(Sprite weaponSprite, Sprite damageSprite, int damageAmount)
    {
        _weaponSprite = weaponSprite;
        _damageSprite = damageSprite;
        _damageAmount = damageAmount;
    }
    
    public void SetWeaponSprite(Sprite weaponSprite)
    {
        _weaponSprite = weaponSprite;
    }

    public void SetDamageSprite(Sprite damageSprite)
    {
        _damageSprite = damageSprite;
    }
    
    public void SetDamageAmount(int damageAmount)
    {
        _damageAmount = damageAmount;
    }
    
    public Sprite GetWeaponSprite()
    {
        return _weaponSprite;
    }

    public Sprite GetDamageSprite()
    {
        return _damageSprite;
    }
    
    public int GetDamageAmount()
    {
        return _damageAmount;
    }


}