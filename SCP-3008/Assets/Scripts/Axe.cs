using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Axe : MonoBehaviour
{
    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    HandBook paperCount;
    HandBook nailCount;
    GameObject player;

    [Header("Give To Player")]
    public int Metal;
    public int Wood;
    public int Cloth;
    public int paper;
    public int nail;

    public void Start()
    {
        player = GameObject.Find("Player");
        metalCount = player.GetComponent<HandBook>();
        woodCount = player.GetComponent<HandBook>();
        clothCount = player.GetComponent<HandBook>();
        paperCount = player.GetComponent<HandBook>();
        nailCount = player.GetComponent<HandBook>();
    }
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Axe"))
        {
            if (Input.GetMouseButtonDown(0))
            {
                metalCount.metalCount += Metal;
                woodCount.woodCount += Wood;
                clothCount.clothCount += Cloth;
                paperCount.paperCount += paper;
                nailCount.nailCount += nail;
                Destroy(gameObject);
            }
        }

    }
   
}
