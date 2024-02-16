using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/*
 * This script is obsolete for the 2d mole use. Used as a reference for current and future purposes.
 */

 public class MoleSpawner : MonoBehaviour
 {
    [SerializeField] GameObject molePrefab;
    [SerializeField] float timeBetweenSpawns;
    float elapsed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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

    private void Spawn()
    {
        GameObject g = Instantiate(molePrefab, transform); //spawns prefab
        int r = Random.Range(-100, 100);
        g.transform.position = new Vector2(r, r); //random position spawn
        //Destroy(g.gameObject, 2);
    }
 }
