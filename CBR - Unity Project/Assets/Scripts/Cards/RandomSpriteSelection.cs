using UnityEngine;

[System.Serializable]
public class RandomSpriteSelection
{
    [SerializeField] private Sprite[] sprites;


    
    public Sprite GetRandomSprite()
    {
        return sprites[Random.Range(0, sprites.Length)];
    }

    public SelectedSprite GetRandomSpriteWithPosition()
    {
        int rSprite = Random.Range(0, sprites.Length);
        SelectedSprite sSprite = new SelectedSprite(sprites[rSprite],rSprite);
        return sSprite;
    }
}

public struct SelectedSprite
{
    public Sprite sprite;
    public int damage;

    public SelectedSprite(Sprite sprite, int damage)
    {
        this.sprite = sprite;
        this.damage = damage + 1;
    }
}