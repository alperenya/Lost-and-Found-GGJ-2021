using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject keyPrefab;
    public GameObject guardPrefab;
    public Transform key0SpawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        GameObject key0 = Instantiate(keyPrefab, key0SpawnPosition.position, Quaternion.identity);
        GameObject key1 = Instantiate(keyPrefab, new Vector3(2, 0, 0), Quaternion.identity);
        GameObject key2 = Instantiate(keyPrefab, new Vector3(-3, 0, 0), Quaternion.identity);
        GameObject guard0 = Instantiate(guardPrefab, new Vector3(3, 0, 0), Quaternion.identity);
        GameObject guard1 = Instantiate(guardPrefab, new Vector3(-1, 0, 0), Quaternion.identity);
        GameObject guard2 = Instantiate(guardPrefab, new Vector3(-5, 0, 0), Quaternion.identity);

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
