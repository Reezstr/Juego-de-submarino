using UnityEngine;

public class ControladorPlataforma : MonoBehaviour
{
    public Sprite plataforma;
    public Sprite plataforma1;
    public Sprite plataforma2;

    public Sprite plataforma3;
    private SpriteRenderer spriteRenderer;
    private int cargas = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = plataforma;
    }

}