using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilboard : MonoBehaviour
{


    // Update is called once per frame
    void LateUpdate()
    {
        RotateToCamera();
    }

    void RotateToCamera()
    {
        transform.LookAt(transform.position + Camera.main.transform.forward);
    }
}
