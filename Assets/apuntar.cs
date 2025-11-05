
using UnityEngine;

public class apuntar : MonoBehaviour
{

    public GameObject player;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.z = 0f; 

        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = rotation;
    }
}
