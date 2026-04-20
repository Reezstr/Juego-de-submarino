using UnityEngine;

public class Controlador : MonoBehaviour
{
    int rotacion = 0;
    int velocidad = 1;
    bool avanzando = true;
    bool rotando = true;
    public float fuerzaMovimiento = 10f;
    public float fuerzaMovimientoAtras = 4f;
    public Rigidbody submarino;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        avanzando = false;
        rotando = false;
    }

    // Update is called once per frame
    void Update()
        {

        Debug.Log("rotando =" + rotando);
        Debug.Log("rotando =" + avanzando);
        
        if (avanzando == false && Input.GetKey("left")){
            rotando = true;
            rotacion += 2;
        }
        if (avanzando == false && Input.GetKey("right")){
            rotando = true;
            rotacion = rotacion - 1;
        }




        if (Input.GetKey("up")) {
        submarino.linearVelocity = transform.up * fuerzaMovimiento;
        }
        if (Input.GetKey("down")) {
        submarino.linearVelocity = -transform.up * fuerzaMovimientoAtras;
        }

        if (submarino.linearVelocity.magnitude < 0.1f) {
        submarino.linearVelocity = Vector3.zero;
        submarino.angularVelocity = Vector3.zero; // Detiene también micro-rotaciones
        }
            
        
        transform.rotation = Quaternion.Euler(0, 0, rotacion);
    }
}
