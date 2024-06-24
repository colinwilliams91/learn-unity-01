using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public GameObject player;
    private GameObject propeller;

    // Start is called before the first frame update
    void Start()
    {
        propeller = player.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(Vector3.forward * 4);
    }
}
