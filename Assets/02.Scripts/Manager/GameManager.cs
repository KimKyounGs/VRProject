using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool bmouseCursor = false;
    public bool bChracterMove = true;
    public bool bUI = false;

    void Start()
    {
        instance = this;
        MouseCursorSetting(bmouseCursor);
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