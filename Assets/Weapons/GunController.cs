using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    // public variables
    public GameObject firePoint;
    public GameObject Bullet;
    public int bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(Bullet, firePoint.transform.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody2D>().AddForce(bulletSpeed * Vector2.right);
        }
    }
}
