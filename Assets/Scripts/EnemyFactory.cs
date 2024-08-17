using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform enemyPosition;
    [SerializeField] private Transform enemyPosition2;
    [SerializeField] private int enemyCreateDelay = 2;
    [SerializeField] private float enemySpeed;

    private void Start()
    {
        StartCoroutine(Enemy());
    }

    public void CreateEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, enemyPosition.position, quaternion.identity);
        Rigidbody2D bulletRigidbody2D = enemy.GetComponent<Rigidbody2D>();
        Vector3 direction = Vector3.up;
        bulletRigidbody2D.AddForce(direction * enemySpeed, ForceMode2D.Impulse);
    }
    public void CreateEnemy1()
    {
        GameObject enemy = Instantiate(enemyPrefab, enemyPosition2.position, quaternion.identity);
        Rigidbody2D bulletRigidbody2D = enemy.GetComponent<Rigidbody2D>();
        Vector3 direction = Vector3.up;
        bulletRigidbody2D.AddForce(direction * enemySpeed, ForceMode2D.Impulse);
    }

    private IEnumerator Enemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(enemyCreateDelay);
            CreateEnemy();
            Destroy(gameObject,1);
            CreateEnemy1();
            Destroy(gameObject,1);

        }
    }

}
