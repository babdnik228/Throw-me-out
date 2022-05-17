using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float speed_Paralax;
    public float endX;
    public float startX;
    private void Update()
    {
        transform.Translate(Vector2.left * speed_Paralax * Time.deltaTime);
        if(transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, 0);
            transform.position = pos;
        }
    }
}
