using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -6);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    // change Update to LateUpdate to avoid jittering camera
    void LateUpdate()
    {
        // follow make camera follow player
        transform.position = player.transform.position + offset;
    }
}
