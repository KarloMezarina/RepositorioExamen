using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject BulletPrefab;
    public float bulletSpeed = 60;

    public float bulletAmount;
    public float bulletAmountTotal=30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (bulletAmount > 0)
            {
                var bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * bulletSpeed;
                Destroy(bullet, 3f);
                bulletAmount -=1;
            }          
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            bulletAmount += bulletAmountTotal;
            bulletAmountTotal = 0;
        }
    }
}
