using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float moveSpeed = 7;
    public bool[] keys = {false, false, false};
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");
        var xMove = x * moveSpeed * Time.deltaTime;
        var yMove = y * moveSpeed * Time.deltaTime;

        Vector3 dir = new Vector3(xMove, yMove, 0);

        rb.MovePosition(transform.position + dir);
    }
}
