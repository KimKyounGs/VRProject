using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveManger : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // 트리거 영역에 객체가 들어올 때 호출됩니다.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered by " + other.gameObject.name);
    }

    // 트리거 영역 안에서 객체가 지속될 때 매 프레임마다 호출됩니다.
    private void OnTriggerStay(Collider other)
    {
        // 지속적인 트리거 처리
        Debug.Log("Triggering " + other.gameObject.name); 
    }

    // 트리거 영역에서 객체가 나갈 때 호출됩니다.
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exited by " + other.gameObject.name);
    }
}
