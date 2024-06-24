using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Camera main;
    public Vector3 offset;

    private Vector3 cameraAngle = new(0, -90, 0);
    private Vector3 resetAngle = Vector3.zero;

    private void Awake()
    {
        CheckCameraDefaults();
    }

    // Start is called before the first frame update
    void Start()
    {
        main.transform.Rotate(cameraAngle);
        main.transform.position = plane.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        main.transform.position = plane.transform.position + offset;
    }

    void CheckCameraDefaults()
    {
        if (main == null)
        {
            Debug.Log("Camera is null");
            main = GetComponent<Camera>();
        }

        if (offset.x != 30 || offset.z != 10)
        {
            Debug.Log("Offset x or z incorrect");
            offset = new Vector3(30, 0, 10);
        }

        if (main.transform.rotation != new Quaternion(0, 0, 0, 0))
        {
            Debug.Log("Camera Rotation Incorrect -- Resetting to 0, 0, 0");
            main.transform.Rotate(resetAngle);
        }
    }
}
