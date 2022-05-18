
using UnityEngine;

public class TrailLogic : MonoBehaviour
{
    [SerializeField] private GameObject trail_rus;
    [SerializeField] private GameObject trail_uc;
    private void Update()
    {
        if (SpriteButton.spriteButton_singolton.is_sprite_Button == true)
        {
            trail_rus.SetActive(true);
            trail_uc.SetActive(false);
        }
        if (SpriteButton.spriteButton_singolton.is_sprite_Button == false)
        {
            trail_uc.SetActive(true);
            trail_rus.SetActive(false);
        }
    }
}
