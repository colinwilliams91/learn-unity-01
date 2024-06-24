using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Camera main;
    public Vector3 offset;

    private void Awake()
    {
        if (main == null)
        {
            Debug.Log("Camera is null");
            main = GetComponent<Camera>();
        }

        if (offset.x != 30 || offset.z != 10)
        {
            offset = new Vector3 (30, 0, 10);
        }

        main.transform.position = plane.transform.position + offset;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        main.transform.position = plane.transform.position + offset;
    }
}
