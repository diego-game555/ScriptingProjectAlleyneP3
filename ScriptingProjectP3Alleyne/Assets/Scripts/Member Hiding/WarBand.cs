using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();
        Enemy1 enemy = new Enemy1();
        Orc orc = new Orc();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
