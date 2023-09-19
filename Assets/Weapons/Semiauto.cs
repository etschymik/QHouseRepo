using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semiauto : MonoBehaviour
{
    // public variables
    public GameObject firePoint;
    public GameObject Bullet;
    public int bulletSpeed;

    // private variables for scripts
    private GunController gunController;

    void Start()
    {
        gunController = gameObject.GetComponent<GunController>();
    }

    void Update()
    {
        ShootBullet();
    }

    void ShootBullet()
    {
        // shoots bullets
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(Bullet, firePoint.transform.position, Quaternion.identity);
            float radRotZ = gunController.rotZ * Mathf.Deg2Rad;
            newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Cos(radRotZ) * bulletSpeed, Mathf.Sin(radRotZ) * bulletSpeed);
        }
    }
}
