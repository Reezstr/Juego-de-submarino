using UnityEngine;
using TMPro;
public class Burbujas : MonoBehaviour
{
    public TMP_Text MostrarMonedas;
    private static int burbujas = 0;
    private void Start()
    {
        
        if (MostrarMonedas == null)
        {
           MostrarMonedas = GameObject.Find("Cambiar monedas").GetComponent<TMP_Text>();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {


        
        if(collision.CompareTag("Submarino"))
            {
                burbujas +=1;
                MostrarMonedas.SetText("burbujas = " + burbujas);
                Destroy(gameObject);
            }
        if(collision.CompareTag("OCUPADO"))
            {
                burbujas +=1;
                MostrarMonedas.SetText("burbujas = " + burbujas);
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
