﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnonlightbehavoir : MonoBehaviour
{
    [SerializeField]
    private Light playerLight = null;

    public float LightFuel = 0;
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
        playerLight.enabled = true;
        if (playerLight.enabled == true)
        {
            if (LightFuel <= 0)
            {
                LightFuel = 0;
                playerLight.enabled = false;
            }
        }
    }
}
