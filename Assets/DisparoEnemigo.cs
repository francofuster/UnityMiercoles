
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{

    public GameObject proyectil;
    public float tiempoDisparos = 1f;

    public float velocidadProyectil = 15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Disparar", 1f, tiempoDisparos);
    }

    // Update is called once per frame
    void Disparar()
    {
        GameObject clonProyectil = Instantiate(proyectil, transform.position, transform.rotation);
        clonProyectil.GetComponent<Rigidbody2D>().linearVelocity = transform.TransformDirection(Vector2.up) * velocidadProyectil;
    }
}
