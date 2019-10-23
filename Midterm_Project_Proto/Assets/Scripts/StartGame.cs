using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public int SceneNum = 0;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneNum);
    }
}
