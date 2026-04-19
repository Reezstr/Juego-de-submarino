using UnityEngine;

public class Controlador : MonoBehaviour
{
    int rotacion = 0;
    int velocidad = 5;
    bool avanzando = true;
    bool rotando = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        avanzando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (avanzando == false && Input.GetKey("left")){
            rotacion += 2;
            rotando = true;
        }
        if (avanzando == false && Input.GetKey("right")){
            rotacion = rotacion - 2;
            rotando = true;
        }


        
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(0, moveVertical, 0);
        transform.Translate(direction * velocidad * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, 0, rotacion);
    }
}
