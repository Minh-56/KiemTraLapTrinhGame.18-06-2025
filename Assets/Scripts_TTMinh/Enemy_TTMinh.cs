using UnityEngine;

public class Enemy_TTMinh : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mario_TTMinh"))
        {
            GameOver_TTMinh.Instance.Gameover_TTMinh();

        }
    }
}
