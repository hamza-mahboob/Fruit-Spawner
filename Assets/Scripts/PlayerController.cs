using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    float time;
    public TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        time = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //countdown and time display
        time -= Time.deltaTime;
        timeText.text = "Time: " + ((int)time).ToString();

        if (time < 0)
        {
            Time.timeScale = 0;
            Debug.Log("Game Over");
        }
    }


}
