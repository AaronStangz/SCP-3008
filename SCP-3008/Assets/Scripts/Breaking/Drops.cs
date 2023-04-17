using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Drops : MonoBehaviour
{
    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    HandBook paperCount;
    HandBook nailCount;
    HandBook scrapWoodCount;
    HandBook scrapMatelCount;
    HandBook matelWireCount;
    [Header("How Much To Give")]
    public int Metal;
    public int Wood;
    public int Cloth;
    public int paper;
    public int nail;
    public int ScrapWood;
    public int ScrapMetal;
    public int MetalWire;

    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        metalCount = player.GetComponent<HandBook>();
        woodCount = player.GetComponent<HandBook>();
        clothCount = player.GetComponent<HandBook>();
        paperCount = player.GetComponent<HandBook>();
        nailCount = player.GetComponent<HandBook>();
        scrapWoodCount = player.GetComponent<HandBook>();
        scrapMatelCount = player.GetComponent<HandBook>();
        matelWireCount = player.GetComponent<HandBook>();
    }
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            trash();
        }

    }

    void trash()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            metalCount.metalCount += Metal;
            woodCount.woodCount += Wood;
            clothCount.clothCount += Cloth;
            paperCount.paperCount += paper;
            nailCount.nailCount += nail;
            scrapWoodCount.scrapWoodCount += ScrapWood;
            scrapMatelCount.scrapMatelCount += ScrapMetal;
            matelWireCount.matelWireCount += MetalWire;

            Destroy(gameObject);
        }
    }


}
