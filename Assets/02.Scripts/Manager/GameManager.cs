using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool bmouseCursor = true;
    public bool bChracterMove = false;

    void Start()
    {
        instance = this;
        bChracterMove = false;
        bmouseCursor = true;
        MouseCursorSetting(bmouseCursor);
    }

    void Update()
    {

    }

    public void MouseCursorSetting(bool flag)
    {
        if (flag == false)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}