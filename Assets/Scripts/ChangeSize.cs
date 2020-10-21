using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    public float rotateAmountDegrees;

    //In each script you will need this
    public TextMesh HUD;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeBig()
    {

        transform.localScale = new UnityEngine.Vector3(transform.localScale.x + 1, transform.localScale.y + 1, transform.localScale.z + 1);

        HUD.text = transform.localScale.ToString(); //update the HUD text after making a change.

    }

    public void MakeSmall()
    {
        transform.localScale = new UnityEngine.Vector3(transform.localScale.x - 1, transform.localScale.y - 1, transform.localScale.z - 1);
        HUD.text = transform.localScale.ToString(); //update the HUD text.


    }

    public void RotateRight()
    {

        transform.Rotate(0.0f, -rotateAmountDegrees, 0.0f, Space.Self);
        HUD.text = transform.rotation.ToString();

    }

    public void RotateLeft()
    {

        transform.Rotate(0.0f, rotateAmountDegrees, 0.0f, Space.Self);
        HUD.text = transform.rotation.ToString();

    }

    public void MoveLeft()
    {
        transform.Translate(UnityEngine.Vector3.left);
        HUD.text = transform.position.ToString();

    }

    public void MoveRight()
    {
        transform.Translate(UnityEngine.Vector3.right);
        HUD.text = transform.position.ToString();

    }
}
