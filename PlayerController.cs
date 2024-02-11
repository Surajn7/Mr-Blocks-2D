using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetAxisRaw("Horizontal") > 0)
       {
            rb.velocity = new Vector2 (speed, 0f);
       }
       else if(Input.GetAxisRaw("Horizontal") < 0)
       {
            rb.velocity = new Vector2(-speed, 0f);
        }
       else if(Input.GetAxisRaw("Vertical") > 0)
       {
            rb.velocity = new Vector2(0f, speed);
        }
       else if(Input.GetAxisRaw("Vertical") < 0)
       {
            rb.velocity = new Vector2(0f, -speed);
       }
       else if(Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0)
       {
            rb.velocity = new Vector2(0f, 0f);
       }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "door")
       {
         Debug.Log("Moving to next Level !!");
       }
    }
}
