using UnityEngine;

public class Coin_TTMinh : MonoBehaviour
{
    private int coinValue = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mario_TTMinh"))
        {
            ScoreManager_TTMinh.instance.AddScore_TTMinh(coinValue);
            Destroy(gameObject);
        }
    }
}
