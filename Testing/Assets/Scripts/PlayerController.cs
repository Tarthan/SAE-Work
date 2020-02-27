using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;        //Distance moved (units per second) when user holds the up or down arrow
    public float turnSpeed = 100f;       //Rotaing speed (degrees per second) when user holds the left or right arrow
    public float jumpHeight = 5f;       // Upward velocity when user presses spacebar.
                                        // Start is called before the first frame update

        // move speed and turnspeed all increase once the player collects enough exp to level up 
    public float currentmoveSpeed;
    public float currentturnSpeed;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Forwards and backwards

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            this.transform.position += this.transform.forward * Time.deltaTime * this.moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            this.transform.position -= this.transform.forward * Time.deltaTime * this.moveSpeed;
        }
        // rotating left and right

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            this.transform.Rotate(this.transform.up, Time.deltaTime * -this.turnSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            this.transform.Rotate(this.transform.up, Time.deltaTime * this.turnSpeed);
        }
        // spacebar to jump.

        if (Input.GetKey(KeyCode.Space) == true && Mathf.Abs(this.GetComponent<Rigidbody>().velocity.y) < 0.01f)
        {
            this.GetComponent<Rigidbody>().velocity += Vector3.up * this.jumpHeight;
        }



    }
}
