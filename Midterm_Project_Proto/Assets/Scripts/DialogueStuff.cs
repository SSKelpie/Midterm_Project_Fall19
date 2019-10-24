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
    public int _storypoints = 0;
    public TextAsset txtfile;
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
        txtlines = txtfile.text.Split('\n');
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
                           
                            istalking = false;
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


    public void FirstSnakeBatch()
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
            

            /*
            speech.text = txtlines[currentline];
            currentline++;
            
            if (currentline == txtlines.Length)
            {
               Debug.Log("FUCK YOUUUUUU");
                _answerstate++;
                _storypoints++;
            }*/
            // speech.text = "Oh hello here! Welcome to the Sssssaudade Cafe!";


        }
    }
    /*
    public void FirstStickBatch()
    {
        if (_answerstate == 1)
        {
            istalking = true;
            
            /*
             
            speech.text = txtlines[currentline];
            currentline++;
            
            if (currentline == txtlines.Length)
            {
               Debug.Log("FUCK YOUUUUUU");
                _answerstate++;
                _storypoints++;
            }*/
            // speech.text = "Oh hello here! Welcome to the Sssssaudade Cafe!";


        }
    


