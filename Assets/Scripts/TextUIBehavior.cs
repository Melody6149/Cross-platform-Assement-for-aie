using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 * This script is used for the ui that shows the player how much time they have remaining 
 */
public class TextUIBehavior : MonoBehaviour
{
    /** This is used to get the text box on the ui so the text can be changed */
    public Text uitext;

    /** This gets the turnonlightbehavior so that i can get the lighttimer variable to use for the ui */
    public Turnonlightbehavior PlayerLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        uitext.text = (PlayerLight.LightTimer.ToString());
    }
}
