using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleColliding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "creature1" && Input.GetKey(KeyCode.Space))
        {
            Debug.Log(("everytime we touch"));

        }

        if (collision.gameObject.tag == "creature2" && Input.GetKey(KeyCode.Space))
        {
            Debug.Log(("I get this feeling"));

        }

        if (collision.gameObject.tag == "creature3" && Input.GetKey(KeyCode.Space))
        {
            Debug.Log(("I swear I could fly"));

        }
    }
}
