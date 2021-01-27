using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    // Start is called before the first frame update
    public int number = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<PlayerController>().keys[number] = true;
            Destroy(gameObject,0.01f);
        }

    }
}
