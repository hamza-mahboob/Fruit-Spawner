using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peach : Fruit
{
    public override void AddScore()
    {
        //adds score once
        base.AddScore();
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        AddScore();
    }
}
