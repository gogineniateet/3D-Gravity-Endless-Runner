using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float playerJumpForce;
    Rigidbody rb;
    ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    // Update is called once per frame
    void Update()
    {
        // changing gravity 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * playerJumpForce);
            Physics.gravity *= -1;          
        }
        // updating score using player distance
        score.ScoreUpdate((int)rb.transform.position.x);
    }

    // player forward movement
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(playerSpeed, rb.velocity.y, rb.velocity.z);
    }

    // destroying player when collides with obstacle
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<ObstacleCollider>() != null)
        {
            Destroy(this.gameObject);
        }
    }
}
