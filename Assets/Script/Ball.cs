using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject _particleDead;
    [SerializeField] private GameObject _museDead;
    [SerializeField] private GameObject _imageDead;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if(bullet != null)
        {
            GameObject particle = Instantiate(_particleDead, transform.position, Quaternion.identity);
            Destroy(particle, 2f);
            GameObject music = Instantiate(_museDead, transform.position, Quaternion.identity);
            Destroy(music, 2f);
            GameObject image = Instantiate(_imageDead, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
