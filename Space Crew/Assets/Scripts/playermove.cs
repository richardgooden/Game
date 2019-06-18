using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermove : MonoBehaviour
{
    public float maxspeed = 5.0f;
    float Heading = 0.0f;
    float speed = 0.0f;
    public int ammo;
    public int health;
    public int fuel;
    public Text ammoTX;
    public Text healthTX;
    public Text fuelTX;
    public Text speedTX;

    // Update is called once per frame
    void FixedUpdate()
    {
        float LR = Input.GetAxis("Horizontal");
        float FB = Input.GetAxis("Vertical");

       
            speed += FB;
       
       Vector3 movement = new Vector3(0.0f, 0.0f, speed * Time.deltaTime);
       transform.Translate( movement);
      
        Heading += LR;
        
        transform.rotation = Quaternion.Euler (0f, Heading * 5f, -LR * 45f );





        ammoTX.text = "Ammo: " + ammo.ToString();
        healthTX.text = "HP: " + health.ToString();
        fuelTX.text = "Fuel: " + fuel.ToString();
        speedTX.text = "Speed:" + speed.ToString();
    }
   
}
