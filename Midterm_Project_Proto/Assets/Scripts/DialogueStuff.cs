using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine.UI;


public class DialogueStuff : MonoBehaviour
{
    public TextMeshProUGUI speech;
    public int _answerstate = 0;
    public int _storypoints = 0;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FirstBatch()
    {
        if (_answerstate == 0)
        {
            speech.text = "Oh hello here! Welcome to the Sssssaudade Cafe!";
          
            _answerstate++;
            _storypoints++;
    }
}