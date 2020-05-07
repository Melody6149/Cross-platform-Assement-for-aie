using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUIBehavoir : MonoBehaviour
{
    public Text uitext;
    [SerializeField]
    private Turnonlightbehavoir PlayerLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        uitext.text = PlayerLight.LightFuel.ToString();
    }
}
