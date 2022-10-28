using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt : MonoBehaviour
{
    public int life = 100;


    public void subtract(int amount)
    {
        life -= amount;
    }
}
