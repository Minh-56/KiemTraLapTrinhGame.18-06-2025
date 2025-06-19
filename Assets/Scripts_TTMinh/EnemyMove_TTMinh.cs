using UnityEngine;

public class EnemyMove_TTMinh : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool canMove = false;

    private void Update()
    {
        if (canMove)
        {
            GetComponent<Rigidbody2D>().linearVelocity =
                new Vector2(transform.localScale.x, 0) * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canMove = collision.gameObject.tag == "Ground_TTMinh";
    }    
}
