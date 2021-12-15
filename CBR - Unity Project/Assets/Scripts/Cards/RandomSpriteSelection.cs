using UnityEngine;

[System.Serializable]
public class RandomSpriteSelection
{
    [SerializeField] private Sprite[] sprites;

    public Sprite GetRandomSprite()
    {
        return sprites[Random.Range(0, sprites.Length)];
    }
}
