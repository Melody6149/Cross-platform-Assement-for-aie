using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavoir : MonoBehaviour
{
    [SerializeField]
    private Light Playerlight;

    //Make sure this is set to the player
    public Transform Player;

    //Use a empty object to set this
    public Transform Hidefromlightlocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the light is on
        if(Playerlight.enabled == true)
        {
            
        }
    }
}
