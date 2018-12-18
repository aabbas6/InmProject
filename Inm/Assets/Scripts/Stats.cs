using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    //class that holds the gameobject's stats [ player + enemies ]
    public int hp;
    public int mp;

    public int armor;
    public int damage;
    public int str;
    public int inte;
    public int dex;
    public float speed;

    public float getMS()
    {
        return speed;
    }

}
