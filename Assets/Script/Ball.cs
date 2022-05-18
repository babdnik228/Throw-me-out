
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject _RU_particleDead;
    [SerializeField] private GameObject _UC_particleDead;
    [SerializeField] private GameObject _museDead;
    [SerializeField] private GameObject _RU_imageDead;
    [SerializeField] private GameObject _UC_imageDead;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if(bullet != null)
        {
            if(SpriteButton.spriteButton_singolton.is_sprite_Button == true)
            {
                GameObject particle_ru = Instantiate(_RU_particleDead, transform.position, Quaternion.identity);
                Destroy(particle_ru, 2f);
            }
            if (SpriteButton.spriteButton_singolton.is_sprite_Button == false)
            {
                GameObject particle_uc = Instantiate(_UC_particleDead, transform.position, Quaternion.identity);
                Destroy(particle_uc, 2f);
            }
            GameObject music = Instantiate(_museDead, transform.position, Quaternion.identity);
            Destroy(music, 2f);
            if (SpriteButton.spriteButton_singolton.is_sprite_Button == true)
            {
                 GameObject imageRu = Instantiate(_RU_imageDead, transform.position, Quaternion.identity);   
            }
            if (SpriteButton.spriteButton_singolton.is_sprite_Button == false)
            {
                GameObject imageUc = Instantiate(_UC_imageDead, transform.position, Quaternion.identity);
            }
           Destroy(gameObject);
        }
    }
}
