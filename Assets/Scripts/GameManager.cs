﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject keyPrefab0;
    public GameObject keyPrefab1;
    public GameObject keyPrefab2;
    public GameObject guardPrefab0;
    public GameObject guardPrefab1;
    public GameObject guardPrefab2;
    public GameObject kadinPrefab;
    public Transform key0SpawnPosition;
    public Transform key1SpawnPosition;
    public Transform key2SpawnPosition;
    public Transform guard0SpawnPosition;
    public Transform guard1SpawnPosition;
    public Transform guard2SpawnPosition;
    public Transform kadınSpawnPosition;


    // Start is called before the first frame update
    void Start()
    {
        GameObject key0 = Instantiate(keyPrefab0, key0SpawnPosition.position, Quaternion.identity);
        GameObject key1 = Instantiate(keyPrefab1, key1SpawnPosition.position, Quaternion.identity);
        GameObject key2 = Instantiate(keyPrefab2, key2SpawnPosition.position, Quaternion.identity);
        GameObject guard0 = Instantiate(guardPrefab0, guard0SpawnPosition.position, Quaternion.identity);
        GameObject guard1 = Instantiate(guardPrefab1, guard1SpawnPosition.position, Quaternion.identity);
        GameObject guard2 = Instantiate(guardPrefab2, guard2SpawnPosition.position, Quaternion.identity);
        GameObject kadin = Instantiate(kadinPrefab, kadınSpawnPosition.position, Quaternion.identity);


        key1.GetComponent<KeyController>().number = 1;
        key2.GetComponent<KeyController>().number = 2;

        guard1.GetComponent<GuardController>().number = 1;
        guard2.GetComponent<GuardController>().number = 2;

    }

    // Update is called once per frame
    void Update()
    {

    }


 
}
