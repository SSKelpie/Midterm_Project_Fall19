using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.UI;


public class DialogueStuff : MonoBehaviour
{
    public TextMeshProUGUI speech;
    public int _answerstate = 0;
    public TextAsset snaketxtfile1;
    public TextAsset skulltxtfile1;
    public TextAsset sticktxtfile1;
    public TextAsset snaketxtfile2;
    public TextAsset skulltxtfile2;
    public TextAsset sticktxtfile2;

    public string[] txtlines;

    public int currentline;

    //public GameObject txtbox;
    public float txtsped;
    public bool istxtin;
    public bool canceltxtin;
    public bool buttonpressed;
    public bool istalking;
    public GameObject txtbox;



    // Start is called before the first frame update
    void Start()
    {
        SwitchTxt(snaketxtfile1);
        //txtbox = Instantiate(txtbox, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity, transform );
        // txtbox.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {

        {
            if (istalking == true && Input.GetKeyDown(KeyCode.Space))
            {
                
                
                if (buttonpressed == true)
                {
                    if (istxtin == false)
                    {
                        currentline++;
                        if (currentline >= txtlines.Length)
                        {
                            txtbox.SetActive(false);
                            buttonpressed = false;
                            istalking = false;
                            _answerstate++;
                        }
                        else
                        {
                            StartCoroutine(typetxt(txtlines[currentline]));

                        }
                    }
                    else if (istxtin == true && canceltxtin == false)
                    {
                        canceltxtin = true;
                        buttonpressed = false;
                    }
                }
                else
                {
                    buttonpressed = true;

                }
            }
         


        }
    }

    private IEnumerator typetxt(string silly)
    {
        int letter = 0;
        speech.maxVisibleCharacters = 0;
        speech.text = silly;
        istxtin = true;
        canceltxtin = false;
        while (istxtin == true && canceltxtin == false && letter < speech.text.Length - 1)
        {
            letter += 1;
            speech.maxVisibleCharacters = letter;
            yield return new WaitForSeconds(txtsped);
        }

        speech.maxVisibleCharacters = speech.text.Length;
        istxtin = false;
        canceltxtin = false;


    }


    /*public void FirstSnakeBatch()
    {
        if (_answerstate == 0)
        {
            istalking = true;
            txtbox.SetActive(true);

            speech.text = txtlines[currentline];


            _answerstate++;
            _storypoints++;
        }
    }
    

    public void FirstSkullBatch()
    {
        //Instantiate(txtbox);
        if (_answerstate == 1)
        {
            istalking = true;



        }
    }
*/
    public void SwitchTxt(TextAsset myfile)
    {
        txtbox.SetActive(true);
        currentline = 0;
        txtlines = myfile.text.Split('\n');
        
        istalking = true;
       

        speech.text = txtlines[currentline];


        
    }
}
    


