using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Controller_2D : MonoBehaviour
{
    public Animator anim; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left") || Input.GetKey("right"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        if(Input.GetKey("space"))
        {
            anim.SetBool("isJump", true);
        }
        else
        {
            anim.SetBool("isJump", false);
        }
        
    }

}
