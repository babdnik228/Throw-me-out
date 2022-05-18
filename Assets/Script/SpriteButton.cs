using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton : MonoBehaviour
{
    public static SpriteButton spriteButton_singolton;
    public bool is_sprite_Button;
    private void Start()
    {
        spriteButton_singolton = this;
    }
    public void Button_Click_Russian()
    {
        is_sprite_Button = true;
    }
    public void Button_Click_Ucrain()
    {
        is_sprite_Button = false;
    }
}
