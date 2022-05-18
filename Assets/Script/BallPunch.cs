
using UnityEngine;

public class BallPunch : MonoBehaviour
{
    public bool is_activ;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            if(is_activ == true)
            {
                collision.GetComponent<Rigidbody2D>().AddForce(transform.right * 350f);
                is_activ = false;
            }
            if (is_activ == false)
            {
                collision.GetComponent<Rigidbody2D>().AddForce(-transform.right * 350f);
                is_activ = true;
            }
        }
    }
}
