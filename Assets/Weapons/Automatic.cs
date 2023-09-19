using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic : MonoBehaviour
{
    // public variables
    public GameObject firePoint;
    public GameObject Bullet;
    public int bulletSpeed;
    public float firingDelay;

    // private variables for scripts
    private GunController gunController;
    private float currentDelay = 0;

    void Start()
    {
        gunController = gameObject.GetComponent<GunController>();
    }

    void Update()
    {
        currentDelay--;
        if (currentDelay <= 0 && Input.GetMouseButton(0)) {
            ShootBullet();
            currentDelay = firingDelay;
        }

    }

    void ShootBullet()
    {
        // shoots bullets
        GameObject newBullet = Instantiate(Bullet, firePoint.transform.position, Quaternion.identity);
        float radRotZ = gunController.rotZ * Mathf.Deg2Rad;
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Cos(radRotZ) * bulletSpeed, Mathf.Sin(radRotZ) * bulletSpeed);
    }
}
