using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitch : MonoBehaviour
{

    public Light ourLight;
    bool lightIsOn = true;
    public TextMesh myHUD;

    // Start is called before the first frame update
    void Start()
    {
        myHUD.text = "light on";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed()
    {
        if(lightIsOn == true)
        {
            //light is on, so turn it off
            ourLight.intensity = 0;
            lightIsOn = false;
            myHUD.text = "light off";
        } else
        {
            //light is off, so turn it on
            ourLight.intensity = 1;
            lightIsOn = true;
            myHUD.text = "light on";
        }



    }
}
