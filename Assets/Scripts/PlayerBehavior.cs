using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
*  This script is used for player movement
*/

public class PlayerBehavior : MonoBehaviour
{
    /** This  is used to set the speed of the player*/
    public float speed = 1.0f;
    /** This will get the character controller of the player*/
    public CharacterController charactercontroller;

    /**This will take in the collider for the enemy so i can check if the trigger is the right trigger */
    public BoxCollider enemy;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetMouseButton(0))
            {
            //get the mouse position;
            Vector3 mousePosition = Input.mousePosition;
            //get a ray from camera to the mouse
            Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
            //create a plane at the player's position
            Plane PlayerPlane = new Plane(Vector3.up, transform.position);
            //Find out how far from the camera the ray intersects the plane
            float rayDistance = 0.0f;
            PlayerPlane.Raycast(mouseRay, out rayDistance);
            //Get the point on the ray at teh distance to the plane
            Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

            // Find the direction
            direction = (targetPoint - transform.position).normalized;
            
        }
        //Apply the speed
        Vector3 movement = direction * speed;

        //Move
        charactercontroller.SimpleMove(movement);
    }
     void OnTriggerEnter(Collider other)
    {
        if(other == enemy)
        {
            Debug.Log("It workes");
            SceneManager.LoadScene(2);
        }
    }
}


