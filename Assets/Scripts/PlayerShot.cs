using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private float shotInterval;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float shotSpeed;
    private float shotTimer;

    private void Update()
    {
        Shot();
    }

    private void Shot()
    {
        shotTimer += Time.deltaTime;
        if (shotTimer >= shotInterval)
        {
            shotTimer = 0;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, quaternion.identity);
            Rigidbody2D bulletRigidbody2D = bullet.GetComponent<Rigidbody2D>();
            Vector3 direction = Vector3.up;
            bulletRigidbody2D.AddForce(direction * shotSpeed, ForceMode2D.Impulse);
        }
    }
}
