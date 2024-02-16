using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Score myScore;
    // Start is called before the first frame update
    void Start()
    {
        myScore = FindObjectOfType<Score>();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        click();
    }

    public void click()
    {
        if (Input.GetMouseButton(0))
        {
            myScore.Points += 1; //adding points to score
            Destroy(gameObject);
        }
    }
}
