using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public int velocity = 5;
    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
        //if (Input.GetKeyDown(KeyCode.D))
        {
            rb2D.AddForce(new Vector2(velocity * Input.GetAxis("Horizontal"),0));
            rb2D.AddForce(new Vector2(0, velocity * Input.GetAxis("Vertical")));
        }

        
    }
    


}