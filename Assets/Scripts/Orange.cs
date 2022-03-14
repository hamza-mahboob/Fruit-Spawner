using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : Fruit
{
    public override void AddScore()
    {
        //adds score twice
        base.AddScore();
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
