using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardlInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");
        // transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);


        // use rotate instead of translate right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);


        //    make vehicle translate right
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // move the vehicle forward
    }
}
