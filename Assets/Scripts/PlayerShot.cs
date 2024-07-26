using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    // [SerializeField] private float shotInterval;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float shotSpeed;
    [SerializeField] private PlayerConfig _config;
    [SerializeField] private int _playerLevel;
    [SerializeField] private List<GameObject> _shootPoints;

    private void Start()
    {
        StartCoroutine(ShootCoroutine());
    }

    private void Update()
    {
         switch(_playerLevel)
        {
            case 1:
                Shoot(_shootPoints[0]);
                break;
            case 2:
                for(int i = 1; i < 3; i++)
                {
                    Shoot(_shootPoints[i]);
                }
                break;
            case 3:
                default:
                break;
        }
    }

    public void Shoot(GameObject point)
    {
        GameObject bullet = Instantiate(bulletPrefab, point.transform.position, quaternion.identity);
        Rigidbody2D bulletRigidbody2D = bullet.GetComponent<Rigidbody2D>();
        Vector3 direction = Vector3.up;
        bulletRigidbody2D.AddForce(direction * shotSpeed, ForceMode2D.Impulse);
    }
    private IEnumerator ShootCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(_config.PlayerShootDelay);
        }
    }
}
