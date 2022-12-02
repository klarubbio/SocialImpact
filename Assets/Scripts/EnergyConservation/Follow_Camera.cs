using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Camera : MonoBehaviour
{
    public Transform Player;
    public float smooth = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 camPosition = new Vector3(Player.position.x, Player.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, camPosition, Time.deltaTime * smooth);
    }
}
