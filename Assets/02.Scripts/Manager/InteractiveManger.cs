using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveManger : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    float MaxDistance = 30f; 

    void Start()
    {
 
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, MaxDistance))
        {
            Debug.Log("Hit + " + hit.transform.name);
        }
    }


}
