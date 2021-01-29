using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<PlayerController>().keys[number])
            {
                Destroy(gameObject);
                //transform.Translate(-0.5f,0,0);
                collision.gameObject.GetComponent<PlayerController>().keys[number] = false;
            }
            
        }

    }
}
