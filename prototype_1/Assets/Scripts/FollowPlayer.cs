using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameraOffset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate will ensure consistency of movement order: vehicle moves THEN camera moves (reduces stuttering)
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }

    void FixedUpdate()
    {
        // no visible difference at this time
        //transform.position = player.transform.position;
    }
}
