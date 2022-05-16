using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolButton : MonoBehaviour
{
    public GameManager gameManager;

    public void SwitchTool(string tool)
    {
        gameManager.currentTool = tool;
    }
}
