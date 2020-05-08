using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBehavior : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;
   
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        moveDirection *= speed;

        controller.Move(moveDirection * Time.deltaTime);
    }
   
}
