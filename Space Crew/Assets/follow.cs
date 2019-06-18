using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;
    private float distance;
    public float FD;

    public float maxspeed = 5.0f;
    float Heading = 0.0f;
    float speed = 0.0f;
    float LR = 0.0f;
    float FB = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 0.1f);
        LR = rotation.y;
        distance = Vector3.Distance(transform.position, target.position);
        if (distance > FD)
        {
            //transform.Translate(0f, 0f, 1f);
            FB = distance * 0.01f;
            speed += FB;

            Vector3 movement = new Vector3(0.0f, 0.0f, speed * Time.deltaTime);
            transform.Translate(movement);

            //Heading = LR;


            transform.Rotate( new Vector3(0f,0f, -LR * 5f));

        }
        else
        {
            speed = 0.0f;
        }
       


       

    }
}
