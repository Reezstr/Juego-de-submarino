using UnityEngine;
using TMPro;
using System.Collections;
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
    public GameObject contenedor;
    public GameObject contenedor2;
    public GameObject contenedor3;
    public Sprite subamarino;
    public Sprite subamarinoContenedor; // Assign this in the Inspector
    private SpriteRenderer spriteRenderer;
    public TMP_Text carga_Activa;
    private int cargas_Entregadas = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        avanzando = false;
        rotando = false;
        retrocediendo = false;
        carga_Activa.text = ("Cargas faltante " + cargas_Entregadas + "/ 3");
    }

    // Update is called once per frame
    void Update()
        {
            



        if (Input.GetKey("space") && gameObject.CompareTag("OCUPADO")){
            contenedor.SetActive(true);
            spriteRenderer.sprite = subamarino;
            gameObject.tag = "Submarino";
            ActivarTextoTemporal();
        }
        if (Input.GetKey("space") && gameObject.CompareTag("OCUPADO")){
            contenedor2.SetActive(true);
            spriteRenderer.sprite = subamarino;
            gameObject.tag = "Submarino";
            ActivarTextoTemporal();
        }
        if (Input.GetKey("space") && gameObject.CompareTag("OCUPADO")){
            contenedor3.SetActive(true);
            spriteRenderer.sprite = subamarino;
            gameObject.tag = "Submarino";
            ActivarTextoTemporal();
        }


        if (submarino.linearVelocity.magnitude < 5f) {
            Debug.Log("tas quieto");
            avanzando = false;
        }

        Debug.Log("rotando =" + rotando);
        Debug.Log("avanzando =" + avanzando);
        
        if (Input.GetKey("left") && avanzando == false){
            rotacion += 0.6f;
        }
        if (Input.GetKey("right") && avanzando == false){
            rotacion = rotacion - 0.6f;
        }
        if (Input.GetKey("left") && avanzando == true){
            rotacion += 0.1f;
        }
        if (Input.GetKey("right") && avanzando == true){
            rotacion = rotacion - 0.1f;
        }


        if (Input.GetKey("up")) {
        submarino.linearVelocity = transform.up * fuerzaMovimiento;
        avanzando = true;
        retrocediendo = false;
        }
        
        if (Input.GetKey("down") ) {
        submarino.linearVelocity = -transform.up * 5.0f;
        avanzando = true;
        }


        if (submarino.linearVelocity.magnitude < 0.5f) {
        submarino.linearVelocity = Vector3.zero;
        submarino.angularVelocity = Vector3.zero;
        }
            
        
        transform.rotation = Quaternion.Euler(0, 0, rotacion);

        }
        private void OnTriggerEnter(Collider collision)
        {
        if(collision.CompareTag("Contenedor"))
            {
                carga_Activa.text = ("CARGA RECOGIDA " + cargas_Entregadas + "/ 3");
                gameObject.tag = "OCUPADO";
                spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = subamarinoContenedor;
            }

        if(collision.CompareTag("Plataforma"))
            {
                gameObject.tag = "Submarino";
                spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = subamarino;
                cargas_Entregadas += 1;
                carga_Activa.text = ("Cargas faltante " + cargas_Entregadas + "/ 3");
            }
         
         }
         


        public void ActivarTextoTemporal()
        {
            StartCoroutine(CambiarTextoPorTiempo());
        }
        IEnumerator CambiarTextoPorTiempo()
        {
        carga_Activa.text = ("CARGA PERDIDA");
        carga_Activa.color = Color.red;
        yield return new WaitForSeconds(2.0f);
        carga_Activa.text = ("Cargas faltante " + cargas_Entregadas + "/ 3");
        carga_Activa.color = Color.white;
     }
    

    
    }
