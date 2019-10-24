using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour {

    // Use this for initialization
    private Animator anim;
    public DialogueStuff number;
    public int SceneNum = 1;
    void Start () 
    {
        anim = gameObject.GetComponent<Animator>();
        number = FindObjectOfType<DialogueStuff>();
        
    }
	
    // Update is called once per frame
    void Update () {
        if (number._answerstate == 6)
        {
            anim.Play("fade OUT");
            ChangeScene();
        }

    }
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneNum);
    }
}
