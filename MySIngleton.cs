using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySingleton 
{
    // hold the names of the scenes to check later
    static public string myFirstScene, mySecondScene;
    static public bool location = true;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //// Return the current Active Scene in order to get the current Scene name.
        //Scene scene = SceneManager.GetActiveScene();

        //// Check if the name of the current Active Scene is your first Scene.
        //if (scene.name == myFirstScene)
        //{
        //    location = false;
        //}
        //else
        //{
        //    location = true;

        //}


        //Scene scene = SceneManager.GetActiveScene();


        //if (currentSceneName == "Second") 
        //{
        //    location = true;
        //}
    }
}
