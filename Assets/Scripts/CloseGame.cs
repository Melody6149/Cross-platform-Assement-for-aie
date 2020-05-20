using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Used to close the game when escape is pushed
 * */


public class CloseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
