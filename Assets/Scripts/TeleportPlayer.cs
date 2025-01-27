using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportPlayer : MonoBehaviour
{
    public InputActionReference action;
    int position;

    void Start()
    {
        position = 0;
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (position == 1)
            {
                transform.position += new Vector3(-50, 0, 0);
                position = 0;
            } else {
                transform.position += new Vector3(50, 0, 0);
                position = 1;
            }
        };
    }

    void Update()
    {

    }
}
