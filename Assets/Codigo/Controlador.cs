using UnityEngine;

public class Controlador : MonoBehaviour
{
    float rotacion = 0f;
    int velocidad = 1;
    bool avanzando = true;
    bool rotando = true;
    bool retrocediendo = true;
    public float fuerzaMovimiento = 20f;
    public float fuerzaMovimientoAtras = 8f;
    public Rigidbody submarino;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        avanzando = false;
        rotando = false;
        retrocediendo = false;
    }

    // Update is called once per frame
    void Update()
        {


        if (submarino.linearVelocity.magnitude < 3.6f) {
            Debug.Log("tas quieto");
            avanzando = false;
        }

        Debug.Log("rotando =" + rotando);
        Debug.Log("avanzando =" + avanzando);
        
        if (Input.GetKey("left") && avanzando == false){
            rotacion += 0.3f;
        }
        if (Input.GetKey("right") && avanzando == false){
            rotacion = rotacion - 0.3f;
        }


        if (Input.GetKey("up")) {
        submarino.linearVelocity = transform.up * fuerzaMovimiento;
        avanzando = true;
        retrocediendo = false;
        }
        
        if (Input.GetKey("down") ) {
        submarino.linearVelocity = -transform.up * 4.0f;
        avanzando = true;
        }


        if (submarino.linearVelocity.magnitude < 0.5f) {
        submarino.linearVelocity = Vector3.zero;
        submarino.angularVelocity = Vector3.zero;
        }
            
        
        transform.rotation = Quaternion.Euler(0, 0, rotacion);
    }
}
