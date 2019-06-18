using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public float speed;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if(Input.GetKey(KeyCode.Mouse1))
      //  {
            this.transform.position = player.position;
            transform.Rotate(0f, Input.GetAxis("Mouse X") * speed * Time.deltaTime, 0f);

      //  }
      //  else
      //  {
     //       this.transform.position = player.position;
      //  }
        
    }
}
