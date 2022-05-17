using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent navmesh;

    public FieldOfView fov;

    // Start is called before the first frame update
    void Start()
    {
        navmesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fov.canSeePlayer == true)
        {
            navmesh.enabled = true;
        }
        else
        {
            navmesh.enabled = false;
        }
    }
}
