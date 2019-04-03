using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripter : MonoBehaviour {

    public Rayo Apuntador;

    void Start ()
    {
        Apuntador.RayCostructorScene();
    }

    private void Update()
    {
        Apuntador.InputSystem();
    }
}
