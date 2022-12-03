using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_PlayerControls : MonoBehaviour
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

        rigidbody.velocity = new Vector3(speed.x * inputX, -1, speed.y * inputY);

        if (rigidbody.velocity.magnitude > 0)
        {
            rigidbody.rotation = Quaternion.LookRotation(new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z), Vector3.up);
        }
    }

}
