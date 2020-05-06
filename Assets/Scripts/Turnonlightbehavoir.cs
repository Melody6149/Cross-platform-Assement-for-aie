using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnonlightbehavoir : MonoBehaviour
{
    [SerializeField]
    private Light playerLight = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hi");
        playerLight.enabled = true;
        if (playerLight.enabled == true)
        {

        }
    }
}
