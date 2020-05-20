using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * This script controls when the light is on or off
 * */
public class Turnonlightbehavior : MonoBehaviour
{
    [SerializeField]
    private Light playerLight = null;

    /** Used to keep track of how much time is left before the light turns off */
    public float LightTimer = 0;

    /**Used to check for collision with the right trigger */
    public Collider lightRecharger;

    /**sets the value that the light will recharge to when the player enters the trigger */
    public float ResetTimerValue = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //LightFuel -= Time.deltaTime;
        LightTimer -= 1 * Time.deltaTime;
        if (LightTimer < 0)
        {
            LightTimer = 0;
        }
            if (playerLight.enabled == true)
        {
            if (LightTimer <= 0)
            {
                LightTimer = 0;
                playerLight.enabled = false;
            }
        }
    }
    //checks for collision
    private void OnTriggerEnter(Collider other)
    {
        //Makes sure only a place that recharges the light activates it
        if (other == lightRecharger)
        {
            Debug.Log("If this is always showing this is not a good thing");
            playerLight.enabled = true;
            LightTimer = ResetTimerValue;
        }
    }
}
