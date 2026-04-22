using UnityEngine;

public class COntenedor : MonoBehaviour
{


    private void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Submarino"))
            {
                gameObject.SetActive(false);
            }
    }
    
}
