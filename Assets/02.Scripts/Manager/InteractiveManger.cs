using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveManger : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public float MaxDistance = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, MaxDistance))
        {
            if (hit.collider.CompareTag("Heritage"))
            {
                if (Input.GetKeyDown(KeyCode.E) && GameManager.instance.bChracterMove == true)
                {
                    hit.collider.GetComponent<HeritageManager>().InteractionEvent();
                }
            }
        }
    }


}
