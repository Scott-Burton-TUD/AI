using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator animator;

    public Animator playerAni;
    // Start is called before the first frame update
    void Awake()
    {
        animator = playerAni.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        animator.GetBool("WASD");
        animator.GetBool("PICKUP");

        if (Input.GetKey(KeyCode.W)) 
        {
            animator.SetBool("WASD", true);
        }
        else
        {
            animator.SetBool("WASD", false);
        }
        
    }
}
