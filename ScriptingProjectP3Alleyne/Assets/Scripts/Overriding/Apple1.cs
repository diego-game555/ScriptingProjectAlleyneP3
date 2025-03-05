using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple1 : Fruit1
{
   public Apple1()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple");
    }
}
