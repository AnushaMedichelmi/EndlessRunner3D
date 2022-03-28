using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerJumpForce;
    public float playerSpeed;
    Rigidbody rb;
    bool IsGrounded = true;
    public int score;
    public Text scoreText;
    public int speedToIncrease;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded==true) // Making player to jump
        {
            rb.AddForce(Vector3.up * playerJumpForce);
            IsGrounded = false;
        }

        //score=transform.position.x;
        score = Mathf.FloorToInt(transform.position.x);
        scoreText.text = score.ToString();
        if (score == speedToIncrease)
        {
            playerSpeed = playerSpeed + 2;
            speedToIncrease = speedToIncrease + 10;
        }



    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector3(playerSpeed, rb.velocity.y, rb.velocity.z);
    }
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Platform")
            IsGrounded = true;

       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<ObstacleController>()!=null)   
        {
            
            Destroy(this.gameObject);
          
            
        }

    }

  
}
