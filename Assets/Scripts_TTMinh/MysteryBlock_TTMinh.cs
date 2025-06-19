using UnityEngine;

public class MysteryBlock_TTMinh : MonoBehaviour
{
    public GameObject coinPrefab;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Mario_TTMinh"))
        {
            Instantiate(coinPrefab, transform.position + Vector3.up * 1f, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}