using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUIBehavior : MonoBehaviour
{
    public Text uitext;
    [SerializeField]
    private Turnonlightbehavior PlayerLight;
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
