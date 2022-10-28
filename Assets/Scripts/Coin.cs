using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject pointObj;
    public int Pointsplus;

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag== "Player")
		{
			pointObj.GetComponent<Score>().score += Pointsplus;
			Destroy(gameObject);
		}
	}


}
