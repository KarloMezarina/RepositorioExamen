using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillCount : MonoBehaviour
{
	public int kills;
	public TMP_Text textKills;

	private void Update()
	{
		textKills.text = "Kills " + kills.ToString();
	}
}
