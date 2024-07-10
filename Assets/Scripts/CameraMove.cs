using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private float cameraSpeed;

    private void Update()
    {
        transform.position += new Vector3(0,cameraSpeed * Time.deltaTime,0);
        
        
    }
}
