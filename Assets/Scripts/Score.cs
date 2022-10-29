using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text texpoints;

    private void Update()
    {
        texpoints.text = "points "+score.ToString();
    }
}
