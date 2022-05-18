using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LogicSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite sprite_russian;
    public Sprite sprite_uc;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if(SpriteButton.spriteButton_singolton.is_sprite_Button == true)
        {
            spriteRenderer.sprite = sprite_russian;
        }
        if(SpriteButton.spriteButton_singolton.is_sprite_Button == false)
        {
            spriteRenderer.sprite = sprite_uc;
        }
    }
}
