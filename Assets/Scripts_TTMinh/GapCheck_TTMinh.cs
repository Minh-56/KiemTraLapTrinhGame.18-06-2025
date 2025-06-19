using UnityEngine;

public class GapCheck_TTMinh : MonoBehaviour
{
    public GameObject Enemy;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground_TTMinh"))
        {
            Enemy.transform.localScale = new Vector3(-Enemy.transform.localScale.x,
                Enemy.transform.localScale.y, Enemy.transform.localScale.z);
        }
    }
}

