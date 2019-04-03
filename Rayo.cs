using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LineRendererQP", menuName = "QP RAY")]
public class Rayo : ScriptableObject
{
    public Gradient gradientRojo;
    public Gradient gradientBlue;

    public GameObject origen;
    LineRenderer selecter;
    public Material colorMaterial;

    public void RayCostructorScene()
    {
        //Valores LineRenderer
        selecter = origen.AddComponent<LineRenderer>();
        selecter.material = colorMaterial;
        selecter.useWorldSpace = false;
        selecter.startWidth = 0.01f;
        selecter.SetPosition(1, new Vector3(0, 0, 5000));
    }

    public void InputSystem()
    {
        /*
        if (OVRInput.Get(OVRInput.NearTouch.SecondaryIndexTrigger) == false)
        {
            Debug.Log("Void Empty");
        }
        */
        if (Input.GetMouseButton(0))
        {
            selecter.colorGradient = gradientRojo;
            selecter.widthMultiplier = 0.01f;
            Debug.Log("Hide");
        }
        else if (Input.GetMouseButton(1))
        {
            selecter.widthMultiplier = 0f;
            Debug.Log("Show");
        }
    }
}
