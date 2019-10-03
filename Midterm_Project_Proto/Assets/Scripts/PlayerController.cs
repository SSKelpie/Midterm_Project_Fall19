using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnspeed;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == (Input.GetKey(KeyCode.UpArrow)))
        {
            this.transform.Translate(new Vector3(0,0,-movespeed* Time.deltaTime));
        }
        if(Input.GetKey (KeyCode.S) == (Input.GetKey(KeyCode.DownArrow)))
        {
            this.transform.Translate(new Vector3(0,0,movespeed* Time.deltaTime));
        }
        if (Input.GetKey (KeyCode.D) == (Input.GetKey(KeyCode.RightArrow))){
            this.transform.Rotate(new Vector3(0,-turnspeed* Time.deltaTime,0));
        }
        if (Input.GetKey (KeyCode.A) == (Input.GetKey(KeyCode.LeftArrow))){
            transform.eulerAngles += new Vector3(0,turnspeed* Time.deltaTime,0);
        }
    }


}




