using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverChange : MonoBehaviour
{

    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeRed()
    {
        r.material.color = Color.red;

    }

    public void MakeGrey()
    {
        r.material.color = Color.grey;

    }
}
