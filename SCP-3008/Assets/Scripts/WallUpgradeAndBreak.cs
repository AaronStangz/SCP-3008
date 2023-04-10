using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class WallUpgradeAndBreak : MonoBehaviour
{
    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    HandBook paperCount;
    HandBook nailCount;
    [Header("GameObject")]
    public GameObject upgradedPrefab;
    public GameObject oldPrefab;
    GameObject player;

    [Header("How Much it Takes")]
    public int Metal;
    public int Wood;
    public int Cloth;
    public int paper;
    public int nail;

    [Header("Need To Upgrade")]
    public int NMetal;
    public int NWood;
    public int NCloth;
    public int Npaper;
    public int Nnail;

    [Header("Give To Player")]
    public int GMetal;
    public int GWood;
    public int GCloth;
    public int Gpaper;
    public int Gnail;




    void Start()
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
        if (collision.gameObject.CompareTag("Player"))
        {
                if (metalCount.metalCount >= NMetal && woodCount.woodCount >= NWood && clothCount.clothCount >= NCloth && paperCount.paperCount >= Npaper && nailCount.nailCount >= Nnail)
                {
                    metalCount.metalCount -= Metal;
                    woodCount.woodCount -= Wood;
                    clothCount.clothCount -= Cloth;
                    paperCount.paperCount -= paper;
                    nailCount.nailCount -= nail;
                    Destroy(oldPrefab);
                    Instantiate(upgradedPrefab, transform.position, transform.rotation);
                }
        }
    }
}
