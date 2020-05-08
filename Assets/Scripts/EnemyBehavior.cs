using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    private Light Playerlight;

    public NavMeshAgent agent;

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
            if(Hidefromlightlocation != null)
            {
                agent.SetDestination(Hidefromlightlocation.transform.position);
            }
        }
        if (Playerlight.enabled == false)
        {
            if (Player != null)
            {
                agent.SetDestination(Player.transform.position);
            }
        }
        
        
    }
    
}
