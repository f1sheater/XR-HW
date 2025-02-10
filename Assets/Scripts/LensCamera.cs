using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensCamera : MonoBehaviour
{
    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position, transform.parent.up);
    }
}
