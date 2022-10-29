using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameObject objPoints;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            objPoints.GetComponent<Score>().score += 10;
            Destroy(gameObject);
        }
    }
}
