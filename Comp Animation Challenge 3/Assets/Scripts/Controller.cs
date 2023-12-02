using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator anim;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("IsJumping", true);
        }

        if (Input.GetKey(KeyCode.E))
        {
            anim.SetBool("IsThrowing", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IsMoving", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("IsJumping", false);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetBool("IsThrowing", false);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("IsMoving", false);
        }


    }
}
