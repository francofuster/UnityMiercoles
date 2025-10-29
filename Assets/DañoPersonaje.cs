using UnityEngine;
using UnityEngine.UI;
 
public class DañoPersonaje : MonoBehaviour
{
 
    public Image barraVida;
    private bool estaVivo = true;
    public float vida = 1f;
 
    private bool recibiendoDaño = false;
    private bool muerte = false;

    public GameObject puntoControl;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("GenerarDaño", 0f, 0.6f);
    }
 
    void Update()
    {
        barraVida.fillAmount = vida;

        if (vida <= 0f && estaVivo)
        {
            estaVivo = false;
            GetComponent<SpriteRenderer>().enabled = false;
            Invoke("reaparecer", 3);
        }
 
    }
 
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemigo")
        {
            recibiendoDaño = true;
        }

        if (other.gameObject.tag == "pinches")
        {
            muerte = true;
        }
    }
 
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemigo")
        {
            recibiendoDaño = true;
        }
    }
 
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "enemigo")
        {
            recibiendoDaño = false;
        }
    }

    // Update is called once per frame
    void GenerarDaño()
    {
        if (recibiendoDaño)
        {
            vida -= 0.2f;
        }

        if (muerte)
        {
            vida -= 1f;
        }
    }
    
    void reaparecer()
    {
        transform.position = puntoControl.transform.position;
        GetComponent<SpriteRenderer>().enabled = true;
        vida = 1f;
        muerte = false;
        estaVivo = true;
    }
}