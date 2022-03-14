using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    Vector3 location;
    static int scoreCount;

    private void Start()
    {
        location = transform.position;
    }
    // Start is called before the first frame update
    public virtual void AddScore()
    {
        scoreCount += 5;
    }

    private void Update()
    {
        Debug.Log("Score: " + scoreCount);
    }
}
