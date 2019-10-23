using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour {

    // Use this for initialization

    public DialogueStuff number;
    public int score;
    public int SceneNum = 1;
    void Start () 
    {
        FindObjectOfType<DialogueStuff>();
        score = number._answerstate;
    }
	
    // Update is called once per frame
    void Update () {
        if (score == 1)
        {
            ChangeScene();
        }

    }
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneNum);
    }
}
