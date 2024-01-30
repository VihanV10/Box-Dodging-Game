using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(70 * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-70 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<-3f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
