using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public static TeleportManager instance;

    // [SerializeField] private Vector3 positionArr[] = new Vector3();
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        
    }


}
