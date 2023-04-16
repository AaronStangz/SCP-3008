using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    [Header("Timer")]
    public BreakTimer breakTimer;
    [Header("Tool Speed")]
    public float Speed = 1;

    public void UseTool(BreakingDrops drops)
    {
        drops.breakTime /= Speed;
        breakTimer.BreakObject(drops);
    }
}
