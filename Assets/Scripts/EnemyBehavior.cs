using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/**
* This script controls where the enemy goes
*/
[RequireComponent(typeof(NavMeshAgent))]
public class EnemyBehavior : MonoBehaviour
{
    /** This gets the light from the player so the enemy script knows if it is on */
    public Light Playerlight;
    /**  This gets the navmeshagent of the enemy */
    public NavMeshAgent Agent;

    //Make sure this is set to the player
    /** This gets the transform of the player */
    public Transform Player;

    //Use a empty object to set this
    /** This stores where the enemy hides when the light is on */
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
            if(Hidefromlightlocation != null)
            {
                Agent.SetDestination(Hidefromlightlocation.transform.position);
            }
        }
        if (Playerlight.enabled == false)
        {
            if (Player != null)
            {
                Agent.SetDestination(Player.transform.position);
            }
        }
        
        
    }
    
}
