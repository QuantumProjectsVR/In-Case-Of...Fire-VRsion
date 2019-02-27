using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Finalizer : MonoBehaviour
{
    public int finalizer = 0;
    public int[] estadisticas = new int[3];
    private bool comprobation = false;  
    private bool save = false;
    void FixedUpdate()
    {
        //Metodo que detiene el contador
        Press();
        //Ejecucion del contador
        if(!comprobation && finalizer == 0){ comprobation = true; StartCoroutine(Count());}
    }

    void Press()
    {
        if(Input.GetKey(KeyCode.F) && !save){finalizer +=1; save=true;}
    }
    
    IEnumerator Count()
    {
        for(int i = 1; i != 0; i++)
        {
            Debug.Log("Segundos: " + i + "s");
            yield return new WaitForSeconds(1f);
            //Condicional que guarda los valores en el arreglo
            if(finalizer != 0 && finalizer < estadisticas.Length && save == true)
            {
                estadisticas[finalizer] = i; save = false;
            }
        }
    }
}
