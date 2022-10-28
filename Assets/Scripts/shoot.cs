using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject BulletInit;
    public GameObject BulletPre;
    public float VelocityBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire"))
        {
            GameObject bulletTemp = Instantiate(BulletPre, BulletInit.transform.position, BulletInit.transform.rotation) as GameObject;
            Rigidbody rb = bulletTemp.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * VelocityBullet);
            Destroy(bulletTemp, 0.5f);
        }
    }
}
