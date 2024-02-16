using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.PackageManager.Requests;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject molePrefab;
    TMP_Text myText;
    int points;
    [SerializeField] float timeBetweenSpawns;
    float elapsed = 0;

    public int Points
    {
        get { return points; }
        set { points = value; myText.text = Points.ToString(); } //setting text points
    }
    // Start is called before the first frame update
    void Start()
    {
        myText = FindObjectOfType<TMP_Text>();
        

    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= timeBetweenSpawns)
        {
            Spawn(); //spawns prefab in random position based on the time between each spawn
            elapsed = 0;
        }
    }

    public void Spawn()
    {
        GameObject mole = Instantiate(molePrefab, transform); //spawns prefab
        float x = Random.Range(0, GetComponent<RectTransform>().rect.width);
        float y = Random.Range(0, GetComponent<RectTransform>().rect.height); //gets the rectangle height and width

        mole.transform.position = new Vector2(x, y);
    }
}


