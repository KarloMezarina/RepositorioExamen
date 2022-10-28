using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_Bar : MonoBehaviour
{
    public Image LifeBar;
    public float ActualLife;
    public float MaximumLife;
    void Update()
    {
        LifeBar.fillAmount = ActualLife / MaximumLife;
    }
}
