using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fruit : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
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
        scoreText.text = "Score: " + scoreCount.ToString();
    }
}
