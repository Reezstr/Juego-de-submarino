using UnityEngine;
using TMPro;
public class ControladorDialogo : MonoBehaviour
{

    public TMP_Text dialogos;
    private int NumeroDialogo = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogos.text = ("hola, estas aqui como el nuevo trabajador en la empreza de transporte maritimo");
        NumeroDialogo = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            NumeroDialogo += 1;
        }
        if (NumeroDialogo == 2)
        {
            dialogos.text = ("Tu labor sera tomar los 3 contenedores y llevarlos a el punto de encuentro, esa plataforma en la que te encuentras");
        }
        if (NumeroDialogo == 3)
        {
            dialogos.text = ("Para controlar tu submarino, usa las flechas izquierda y derecha para rotar, y las de adelante y atras para avanzar");
        }
        if (NumeroDialogo == 4)
        {
            dialogos.text = ("ten en cuenta que si rotas mientras avanzas, giraras mas lento, y que la velocidad hacia atras es mas baja");
        }
        if (NumeroDialogo == 5)
        {
            dialogos.text = ("Si te chocas con una tuberia mientras llevas un contenedor, lo soltaras y este volvera a donde estaba por.... la magia de los videojuegos");
        }
        if (NumeroDialogo == 6)
        {
            dialogos.text = ("Tambien puedes recolectar las multiples burbujas que hay por todo el mapa, y puedes intentar coleccionarlas todas");
        }
        if (NumeroDialogo == 7)
        {
            dialogos.text = ("No conseguiras nada por hacerlo, pero en los juegos siempre debes coleccionar algo, y ey, a lo mejor encuentras tu vocacion como coleccionador de burbujas");
        }
        if (NumeroDialogo == 8)
        {
            dialogos.text = ("Que te diviertas :)");
        }
        if (NumeroDialogo == 9)
        {
            dialogos.text = ("");
            Destroy(gameObject);
        }
    }
}
