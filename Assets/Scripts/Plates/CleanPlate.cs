using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanPlate : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float decrease = 1.0f;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        decrease -= 0.1f;
        Debug.Log(decrease);
        meshRenderer.materials[1].color = new Color(1f, 1f, 1f, decrease);
        if (decrease < 0)
        {
            decrease = 0;
        }
    }
}
