using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float timeToLive;

    // Update is called once per frame
    void Update()
    {
        timeToLive--;
        if (timeToLive <= 0)
        {
            Destroy(gameObject);
        }
    }
}
