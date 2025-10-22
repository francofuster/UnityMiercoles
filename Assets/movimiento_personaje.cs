using UnityEngine;
 
public class movimiento_personaje : MonoBehaviour
{
 
    public float Velocidad = 5f;
    public float FuerzaSalto = 8f;
    private Rigidbody2D rb;
    private bool puedeSaltar = false;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Velocidad * Time.deltaTime, 0f, 0f);
            // rb.linearVelocity = new Vector2(Velocidad * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(Velocidad * Time.deltaTime, 0f, 0f);
            // rb.linearVelocity = new Vector2(-Velocidad * Time.deltaTime, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space) &&   puedeSaltar)    
        {
            rb.AddForce(new Vector2(0f, FuerzaSalto), ForceMode2D.Impulse);
        }
    }
 
    void OnCollisionEnter2D(Collision2D objeto)
    {
        if (objeto.gameObject.tag == "Floor")
        {
            Debug.Log("No puede saltar");
            puedeSaltar = true;
        }
    }
 
     void OnCollisionExit2D(Collision2D objeto)
    {
        if(objeto.gameObject.tag == "Floor")
        {
            Debug.Log("Puede saltar");
            puedeSaltar = false;
        }
    }
}