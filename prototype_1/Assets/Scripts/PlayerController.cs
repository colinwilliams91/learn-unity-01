using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _speed = 0.5f;
        // TODO: move the vehicle forward
        transform.Translate(0, 0, _speed);
    }
}
