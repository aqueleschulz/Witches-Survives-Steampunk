using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwutchImageScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public int spriteQuantity;

    void Awake()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();

        int i = Random.Range(0, spriteQuantity);
        spriteRenderer.sprite = sprites[i];
    }
}
