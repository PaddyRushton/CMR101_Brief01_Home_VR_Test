using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MakeSmallButtonScript : MonoBehaviour
{
    public ChangeSize objectToChangeSize;
    public XRGrabInteractable grabInteractable = null;

    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(MakeBig);
        grabInteractable.onDeactivate.AddListener(MakeBig);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MakeBig(XRBaseInteractor interactor)
    {
        objectToChangeSize.MakeSmall();    }
}
