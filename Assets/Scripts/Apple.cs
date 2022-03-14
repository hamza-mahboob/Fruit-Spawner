using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    public override void AddScore()
    {
        //adds score three time
        base.AddScore();
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
