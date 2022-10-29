using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy();
		}

        if (other.tag == "Enemy")
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
