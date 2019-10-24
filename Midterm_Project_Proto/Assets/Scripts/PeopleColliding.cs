using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeopleColliding : MonoBehaviour
{
    public DialogueStuff DA;
    public bool answerstate = false;
   


    // Start is called before the first frame update
    void Start()
    {
        DA = FindObjectOfType<DialogueStuff>();

    }

    // Update is called once per frame
        void OnTriggerStay(Collider collision)
        {
            Debug.Log(collision.gameObject.tag);
            if (collision.gameObject.tag == "creature1" && Input.GetKeyDown(KeyCode.Space))
            {

               
                if (DA.istalking == false)
                {
                    Debug.Log(("everytime we touch"));
                    DA.SwitchTxt(DA.snaketxtfile1);
                    
                }
                if(answerstate == false && DA._answerstate == 5)
                {
                    DA.SwitchTxt(DA.snaketxtfile2);
                    answerstate = true;
                }
            }
           

            if (collision.gameObject.tag == "creature2" && Input.GetKeyDown(KeyCode.Space))
            {
                

                if (DA.istalking == false)
                {
                    Debug.Log(("I get this feeling"));
                    DA.SwitchTxt(DA.skulltxtfile1);
                }
                if(answerstate == false && DA._answerstate == 3)
                {
                   DA.SwitchTxt(DA.skulltxtfile2);
                   answerstate = true;
                }
                

            }

            if (collision.gameObject.tag == "creature3" && Input.GetKeyDown(KeyCode.Space))
            {

                if (DA.istalking == false)
                {
                Debug.Log(("I swear I could fly"));
                DA.SwitchTxt(DA.sticktxtfile1);
            }
                if(answerstate == false && DA._answerstate == 4)
                {
                    DA.SwitchTxt(DA.sticktxtfile2);
                    answerstate = true;
                }

            } 
        }
    }

