using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykillcount : MonoBehaviour
{
	public GameObject killObj;
	public int killsplus;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "bullet")
		{
			killObj.GetComponent<KillCount>().kills += killsplus;
			Destroy(gameObject);
		}
	}
}
