using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Bullet"))
		{
            Destroy();
		}
        
        if(collision.collider.CompareTag("Enemy"))
		{
            Destroy();
		}
    }

    // Update is called once per frame
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
