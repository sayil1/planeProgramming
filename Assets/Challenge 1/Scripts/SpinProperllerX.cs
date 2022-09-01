using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinProperllerX : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationSpeed = 20.0f;
    private Vector3 rotation = new Vector3(0, 0, 10);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);

    }
}
