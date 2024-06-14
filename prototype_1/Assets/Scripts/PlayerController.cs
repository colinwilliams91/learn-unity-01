using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // TODO: init obstacle physics?
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Vector3.forward == 0, 0, 1 (3 points)
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);

    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward);
    }
}
