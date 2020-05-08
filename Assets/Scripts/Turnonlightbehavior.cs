using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnonlightbehavior : MonoBehaviour
{
    [SerializeField]
    private Light playerLight = null;

    public float LightFuel = 0;

    //Used to check for collision with the right trigger
    public Collider lightRecharger;

    //sets the value that the light will recharge to when the player enters the trigger
    public float RechargeLight = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //LightFuel -= Time.deltaTime;
        LightFuel -= 1 * Time.deltaTime;
        if (LightFuel < 0)
        {
            LightFuel = 0;
        }
            if (playerLight.enabled == true)
        {
            if (LightFuel <= 0)
            {
                LightFuel = 0;
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
            LightFuel = RechargeLight;
        }
    }
}
