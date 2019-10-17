using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCon : MonoBehaviour {

    // Use this for initialization

    public DialogueStuff number;
    public int score;
    void Start () 
    {
        FindObjectOfType<DialogueStuff>();
        score = number._answerstate;
    }
	
    // Update is called once per frame
    void Update () {
        if (score == 1)
        {
            GameObject.Find("WinGame").GetComponent<SceneManger>().ChangeScene();
        }

    }
}
