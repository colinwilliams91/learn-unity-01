using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class PlayerController : MonoBehaviour
{
    [RequiredMember]
    public float speed = 15f;
    [RequiredMember]
    public float turnSpeed = 1f;
    [RequiredMember]
    public float horizontalInput;

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
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);

    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //transform.Translate(Vector3.forward);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
