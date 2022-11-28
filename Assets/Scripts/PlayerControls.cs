using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);

    public Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
    }


    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        rigidbody.velocity = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        if (rigidbody.velocity.magnitude > 0)
        {
            rigidbody.rotation = Quaternion.LookRotation(rigidbody.velocity, Vector3.back);
        }
    }

}
