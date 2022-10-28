using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
	public int kills;
	public Text textKills;

	private void Update()
	{
		textKills.text = "Kills " + kills.ToString();
	}
}
