using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Extinguisher", menuName = "Extintor QP")]
public class Extinguisher : ScriptableObject
{
    public Material colorExt;

    public GameObject modelExtinguisher;
    private GameObject modelBoquilla;
    private LineRenderer lineHose;
    private int damageFire;

    public void ChangeMaterial()
    {
        modelExtinguisher.GetComponent<Renderer>().material = colorExt;
    }

    public void Apagar()
    {
        Debug.Log("Apagado");
    }
    public void Residuos()
    {
        Debug.Log("Residuos");
    }
}
