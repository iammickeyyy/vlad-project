
using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float shotSpeed;
    [SerializeField] private PlayerConfig _config;
    [SerializeField] private int _playerLevel = 1;
    [SerializeField] private Transform _shootPoint1;
    [SerializeField] private Transform _shootPoint2;
    [SerializeField] private Transform _shootPoint3;
    private void Start()
    {
        StartCoroutine(ShootCoroutine());
    }
    public void Shoot()
    {
        switch (_playerLevel)
        {
            case 1:
            		CreateBullet(_shootPoint1);
                break;
            case 2:
            		CreateBullet(_shootPoint2);
                CreateBullet(_shootPoint3);
                break;
            case 3:
            		CreateBullet(_shootPoint1);
                CreateBullet(_shootPoint2);
                CreateBullet(_shootPoint3); 
                break;
        }        
    }
    
    private void CreateBullet(Transform point)
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
            Shoot();
        }
    }
}
