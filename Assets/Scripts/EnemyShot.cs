using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
   [SerializeField] private GameObject bulletPrefab;
   [SerializeField] private float bulletSpeed;
   [SerializeField] private Transform shotPosition;

   private void Start()
   {
      StartCoroutine(ShootCorouatine());
   }

   private void CreateBullet()
   {
      GameObject bullet = Instantiate(bulletPrefab, shotPosition.position, quaternion.identity);
      Rigidbody2D bulletRigidbody2D = bullet.GetComponent<Rigidbody2D>();
      Vector3 direction = Vector3.down;
      bulletRigidbody2D.AddForce(direction * bulletSpeed, ForceMode2D.Impulse);
   }
   private IEnumerator ShootCorouatine()
   {
      while (true)
      {
         yield return new WaitForSeconds(2);
         CreateBullet();
      }
   }
}
