using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Drops : MonoBehaviour
{
    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    public int Metal;
    public int Wood;
    public int Cloth;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        metalCount = player.GetComponent<HandBook>();
        woodCount = player.GetComponent<HandBook>();
        clothCount = player.GetComponent<HandBook>();
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
            Destroy(gameObject);
        }
    }
}
