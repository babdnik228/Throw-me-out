using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public static Shot shot_singl;
    [SerializeField]
    private float Power;
    [SerializeField]
    private GameObject bulletPrefab;
    private Camera mainCamera;
    public static int bulletAmount = 2;
    [SerializeField] private int bulletInsAmount;
    private void Start()
    {
        shot_singl = this;
        bulletAmount = bulletInsAmount;
        mainCamera = Camera.main;
    }
    private void Update()
    {
        float enter;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        new Plane(-Vector3.right, transform.position).Raycast(ray, out enter);
        Vector3 mousWord = ray.GetPoint(enter);

        Vector3 speed = (mousWord - transform.position) * Power;
        transform.rotation = Quaternion.LookRotation(speed);

        if (Input.GetMouseButtonDown(0))
        {
            
            if(bulletAmount == 0)
            {
                Debug.Log("Нет Патронов");
            }
            if(bulletAmount > 0)
            {
                bulletAmount--;
                Rigidbody2D bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
                bullet.AddForce(speed, ForceMode2D.Impulse);
            }   
        }
    }
}
