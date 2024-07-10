using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 step = new Vector3(hor, ver, 0);
        transform.position += step * moveSpeed * Time.deltaTime;

    }
}
