using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool mouseCursor = false;

    void Start()
    {
        instance = this;
        MouseCursorSetting(mouseCursor);
    }

    void Update()
    {

    }

    void MouseCursorSetting(bool flag)
    {
        if (flag == false)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}