using UnityEngine;
using UnityEngine.UI;
 
public class DañoPersonaje : MonoBehaviour
{
 
    public Image barraVida;
 
    public float vida = 1f;
 
    private bool recibiendoDaño = false;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("GenerarDaño", 0f, 1f);
    }
 
    void Update()
    {
        barraVida.fillAmount = vida;
 
 
    }
 
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemigo")
        {
            recibiendoDaño = true;
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
        if(recibiendoDaño)
        {
            vida -= 0.2f;
        }
    }
}