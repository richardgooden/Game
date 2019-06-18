using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float maxspeed = 5.0f;
    float Heading = 0.0f;
    float speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        print("yo im a cube");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float LR = Input.GetAxis("Horizontal");
        float FB = Input.GetAxis("Vertical");

       //if(speed < maxspeed && speed > -maxspeed)
       // {
            speed += FB;
       // }
       //if(speed > maxspeed) { speed = maxspeed; }
      // if(speed < -maxspeed) { speed = -maxspeed; }
       
       Vector3 movement = new Vector3(0.0f, 0.0f, speed * Time.deltaTime);
       transform.Translate( movement);
                
                
                // } else if (FB < -0.1)
       // {
       //     Vector3 movement = new Vector3(0.0f, 0.0f, FB);
       //     GetComponent<Rigidbody>().AddRelativeForce(movement);
       // };

        
        //GetComponent <Rigidbody>().velocity = movement * speed;
        //GetComponent<Rigidbody>().velocity. = movement * maxspeed;// 
        //transform.Translate(0.0f, 0.0f, speed);
        Heading += LR;
        //if (speed < maxspeed)
        // {
        //    speed += FB;
        // };
        transform.rotation = Quaternion.Euler (0f, Heading *50 * Time.deltaTime, 0f);
        
        //GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, Heading, 0.0f);

    }
    void Update()
    {
        
    }
}
