using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float strafeSpeed;
    public float jumpForce;

    public Rigidbody hips;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        hips = GetComponent<Rigidbody>();    
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                hips.AddForce(hips.transform.up * speed * 1.5f);//up  is forward for Robot Kyle model
            }
            else{
                hips.AddForce(hips.transform.up * speed);
            }

            
        }
        if(Input.GetKey(KeyCode.A))
        {
            
                hips.AddForce(-hips.transform.forward * strafeSpeed);
            
        }

        if(Input.GetKey(KeyCode.S))
        {
            
                hips.AddForce(-hips.transform.up * speed);
            
        }
        if(Input.GetKey(KeyCode.D))
        {
            
                hips.AddForce(hips.transform.forward * strafeSpeed);
            
        }

        if(Input.GetKey(KeyCode.Space))
        {
            if(isGrounded)
            {
                hips.AddForce(new Vector3(0, jumpForce, 0));
                isGrounded = false;
            }
        }

        
    }
    
}
