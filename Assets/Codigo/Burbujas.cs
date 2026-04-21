using UnityEngine;
using TMPro;
public class Burbujas : MonoBehaviour
{
    public TMP_Text MostrarMonedas;
    private static int burbujas = 0;
    private void Start()
    {
        // Solo buscamos el texto si no ha sido asignado antes por otra burbuja
        if (MostrarMonedas == null)
        {
            MostrarMonedas = Object.FindFirstObjectByType<TMP_Text>();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {


        
        if(collision.CompareTag("Submarino"))
            {
                burbujas +=1;
                MostrarMonedas.text = ("burbujas = " + burbujas);
                Destroy(gameObject);
            }
    
    

    }
    public void  AumentarBurbujas(int amount)
    {
        burbujas += amount;
        if (MostrarMonedas != null)
        {
            MostrarMonedas.text = "Burbujas: " + burbujas;
        }
    }
}
