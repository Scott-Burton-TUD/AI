using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Spawn;

    public GameObject Enemy;
    public GameObject Patrol;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject == Enemy)
        {
            transform.position = Spawn.position;
        }

        if (hit.gameObject == Patrol)
        {
            transform.position = Spawn.position;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Enemy)
        {
            transform.position = Spawn.position;
        }

        if (collision.gameObject == Patrol)
        {
            transform.position = Spawn.position;
        }
    }
}
