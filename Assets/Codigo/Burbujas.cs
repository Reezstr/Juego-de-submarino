using UnityEngine;

public class Burbujas : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hastriggered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("submarino") && !hastriggered)
        {
            hastriggered = true;
            Destroy(gameObject);
        }
    }
}
