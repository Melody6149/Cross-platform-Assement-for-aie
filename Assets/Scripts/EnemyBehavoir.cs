using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class EnemyBehavoir : MonoBehaviour
{
    [SerializeField]
    private Light Playerlight;

    public CharacterController controller;

    public int speed;

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
        Vector3 moveDirection = new Vector3(0, 0, 0);
        //Checks if the light is on
        if(Playerlight.enabled == true)
        {
            if(Hidefromlightlocation != null)
            {
                moveDirection = Hidefromlightlocation.position - transform.position;
                moveDirection.Normalize();
            }
        }
        if (Playerlight.enabled == false)
        {
            if (Player != null)
            {
                moveDirection = Player.position - transform.position;
                moveDirection.Normalize();
            }
        }
        moveDirection *= speed;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
