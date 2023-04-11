using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class BreakingDrops : MonoBehaviour
{

    [Header("Give To Player")]
    public int Metal;
    public int Wood;
    public int Cloth;
    public int paper;
    public int nail;

    public float breakTime = 1f;

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Tool"))
        {
            if (Input.GetMouseButtonDown(0))
            {
                collision.GetComponent<Tool>().UseTool(this);
            }
        }
    }
}
